using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BallScript : MonoBehaviour {
    
    public Vector2 velocity;
    public Collider2D col;

    private Animator ballanim;

    private SoundManager smanager;
    private GameManager gmanager;

    public enum temperature {NEUTRAL, HOT, COLD };
    public temperature temper;

    public float init_X;
    public float init_Y;
    

    public Rigidbody2D rbody;

    public float speed;

    void Start () {

        ballanim = GetComponent<Animator>();

        speed = 50;

        smanager = GameObject.Find("SFX manager").GetComponent<SoundManager>();

        Vector2 ballPosition = gameObject.transform.position;
        Vector2 delta = ballPosition - (ballPosition + new Vector2(2, 2));
        Vector2 direction = delta.normalized;
        rbody.velocity = direction * speed;

    }

    public void kickstart() {
        // credit to the people on the unity forums
        Vector2 ballPosition = gameObject.transform.position;
        Vector2 delta = ballPosition - (ballPosition + new Vector2(2, 2));
        Vector2 direction = delta.normalized;
        rbody.velocity = direction * speed;
    }


    //Notes 24/07/2018: I could have honestly called the kickstart function rather than copying and pasting...
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Blocks") && (col.gameObject.name != "Block_Nothing"))
        {
            // changing temperature when hit
            switch (temper)
            {
                case temperature.NEUTRAL:
                    if (col.gameObject.name == "Block_Hot" || col.gameObject.name == "Block_Lava") { temper = temperature.HOT;

                        Vector2 boxPosition = col.transform.position;
                        Vector2 ballPosition = gameObject.transform.position;

                        // credit to the people on the unity forums
                        Vector2 delta = ballPosition - boxPosition;
                        Vector2 direction = delta.normalized;
                        rbody.velocity = direction * speed;
                        smanager.Bound.Play();
                    }
                    if (col.gameObject.name == "Block_Cold" || col.gameObject.name == "Block_Frost") { temper = temperature.COLD; 
                            
                        Vector2 boxPosition = col.transform.position;
                        Vector2 ballPosition = gameObject.transform.position;

                        Vector2 delta = ballPosition - boxPosition;
                        Vector2 direction = delta.normalized;
                        rbody.velocity = direction * speed;
                        smanager.Bound.Play();
                    }

                    if (col.gameObject.name == "Block_Neutral") {
                        Vector2 boxPosition = col.transform.position;
                        Vector2 ballPosition = gameObject.transform.position;

                        Vector2 delta = ballPosition - boxPosition;
                        Vector2 direction = delta.normalized;
                        rbody.velocity = direction * speed;
                        smanager.Bound.Play();
                    }
                        break;

                case temperature.HOT:
                    if (col.gameObject.name == "Block_Cold" || col.gameObject.name == "Block_Frost") { temper = temperature.NEUTRAL;

                        Vector2 boxPosition = col.transform.position;
                        Vector2 ballPosition = gameObject.transform.position;

                        Vector2 delta = ballPosition - boxPosition;
                        Vector2 direction = delta.normalized;
                        rbody.velocity = direction * speed;
                        smanager.Bound.Play();
                    }

                    if (col.gameObject.name == "Block_Neutral")
                    {
                        Vector2 boxPosition = col.transform.position;
                        Vector2 ballPosition = gameObject.transform.position;

                        Vector2 delta = ballPosition - boxPosition;
                        Vector2 direction = delta.normalized;
                        rbody.velocity = direction * speed;
                        smanager.Bound.Play();
                    }
                    break;

                case temperature.COLD:
                    if (col.gameObject.name == "Block_Hot" || col.gameObject.name == "Block_Lava") { temper = temperature.NEUTRAL;

                        Vector2 boxPosition = col.transform.position;
                        Vector2 ballPosition = gameObject.transform.position;

                        Vector2 delta = ballPosition - boxPosition;
                        Vector2 direction = delta.normalized;
                        rbody.velocity = direction * speed;
                        smanager.Bound.Play();
                    }

                    if (col.gameObject.name == "Block_Neutral")
                    {
                        Vector2 boxPosition = col.transform.position;
                        Vector2 ballPosition = gameObject.transform.position;

                        // credit to the people on the unity forums
                        Vector2 delta = ballPosition - boxPosition;
                        Vector2 direction = delta.normalized;
                        rbody.velocity = direction * speed;
                        smanager.Bound.Play();
                    }

                    
                    break;

            }
            if ((col.gameObject.GetComponent<TileBlock>().dest == TileBlock.destructable.INDESTRUCTABLE)) {

                if (temper == temperature.COLD) { gmanager.temperatureBalls--; }
                if (temper == temperature.HOT) { gmanager.temperatureBalls++; }

                Vector2 boxPosition = col.transform.position;
                Vector2 ballPosition = gameObject.transform.position;

                // credit to the people on the unity forums
                Vector2 delta = ballPosition - boxPosition;
                Vector2 direction = delta.normalized;
                rbody.velocity = direction * speed;
                smanager.Bound.Play();
            }
       }
    }

    void Update () 
    {
        gmanager = GameObject.FindGameObjectWithTag("Level").GetComponent<GameManager>();

        switch (temper)
        {
            case temperature.NEUTRAL:
                ballanim.SetInteger("Block",0);
                break;
            case temperature.HOT:
                ballanim.SetInteger("Block", 1);
                break;
            case temperature.COLD:
                ballanim.SetInteger("Block", -1);
                break;
        }
        transform.Translate(velocity * speed * Time.deltaTime, Space.World);
       
    }
}
