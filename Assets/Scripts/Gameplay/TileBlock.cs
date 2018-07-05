using UnityEngine;
using System.Collections;
using System.Linq;

public class TileBlock : MonoBehaviour {

    public enum temperature { NEUTRAL, HOT, COLD };
    public temperature temp;

    public enum destructable { BREAKABLE, INDESTRUCTABLE, NONE };
    public destructable dest;

    public Collider2D col;

    public SpriteRenderer block_colour;
    public string block_name;

    public int x;
    public int y;

    public int id;

    public Sprite[] block_colour_sprites;

    private Sprite cold;
    private Sprite hot;
    private Sprite neutral;
    private Sprite wall;
    private Sprite frost;
    private Sprite lava;
    // Use this for initialization
    void Start () {
        block_colour = GetComponent<SpriteRenderer>();

        x = Mathf.RoundToInt( transform.position.x) / 20;
        y = Mathf.RoundToInt(transform.position.y) / 20;

        col = GetComponentInChildren<BoxCollider2D>();

        block_colour_sprites = Resources.LoadAll<Sprite>("Block_texture/");
        cold = block_colour_sprites.Single(s => s.name == "blocks_0");
        hot = block_colour_sprites.Single(s => s.name == "blocks_1");
        wall = block_colour_sprites.Single(s => s.name == "blocks_3");
        neutral = block_colour_sprites.Single(s => s.name == "blocks_2");
        lava = block_colour_sprites.Single(s => s.name == "blocks_6");
        frost = block_colour_sprites.Single(s => s.name == "blocks_5");
    }

    // Update is called once per frame
    void Update () {

        this.gameObject.name = block_name;



        switch(temp){
            
            case temperature.NEUTRAL:
                switch (dest) {
                    case destructable.INDESTRUCTABLE:
                        id = 4;
                        block_name = "Block_Wall";
                        block_colour.sprite = wall;
                        break;
                    case destructable.BREAKABLE:
                        id = 3;
                        block_name = "Block_Neutral";
                        block_colour.sprite = neutral;
                        break;
                    case destructable.NONE:
                        id = 0;
                        block_name = "Block_Nothing";
                        block_colour.sprite = null;
                        break;
                }
                break;
            case temperature.HOT:

                switch (dest)
                {
                    case destructable.INDESTRUCTABLE:
                        id = 6;
                        block_name = "Block_Lava";
                        block_colour.sprite = lava;
                        break;
                    case destructable.BREAKABLE:
                        id = 1;
                        block_name = "Block_Hot";
                        block_colour.sprite = hot;
                        break;
                }
                break;
            case temperature.COLD:

                switch (dest)
                {
                    case destructable.INDESTRUCTABLE:
                        id = 5;
                        block_name = "Block_Frost";
                        block_colour.sprite = frost;
                        break;
                    case destructable.BREAKABLE:
                        id = 2;
                        block_name = "Block_Cold";
                        block_colour.sprite = cold;
                        break;
                }
                break; 
        }
	}

    //collision with ball
    void OnTriggerEnter2D(Collider2D col) {
        BallScript ball_temperature = col.gameObject.GetComponent<BallScript>();
        if (col.gameObject.CompareTag("Ball")) {
            switch (dest) {
                case destructable.BREAKABLE:
                    switch (temp)
                    {
                        case temperature.NEUTRAL:
                            if (ball_temperature.temper == BallScript.temperature.COLD) { temp = temperature.COLD; }
                            if (ball_temperature.temper == BallScript.temperature.HOT) { temp = temperature.HOT; }
                            if (ball_temperature.temper == BallScript.temperature.NEUTRAL) { temp = temperature.NEUTRAL; dest = destructable.NONE; }
                            break;
                        case temperature.COLD:
                            if (ball_temperature.temper == BallScript.temperature.HOT) { temp = temperature.NEUTRAL; }
                            break;
                        case temperature.HOT:
                            if (ball_temperature.temper == BallScript.temperature.COLD) { temp = temperature.NEUTRAL; }
                            break;
                    }
                    break;

                case destructable.INDESTRUCTABLE:
                   /* switch (temp)
                    {
                        case temperature.COLD:
                            if (ball_temperature.temper == BallScript.temperature.NEUTRAL) { ball_temperature.temper = BallScript.temperature.COLD; }
                            if (ball_temperature.temper == BallScript.temperature.HOT) { ball_temperature.temper = BallScript.temperature.NEUTRAL; }
                            break;
                        case temperature.HOT:
                            if (ball_temperature.temper == BallScript.temperature.NEUTRAL) { ball_temperature.temper = BallScript.temperature.HOT; }
                            if (ball_temperature.temper == BallScript.temperature.COLD) { ball_temperature.temper = BallScript.temperature.NEUTRAL; }
                            break;
                    }*/
                    break;
                case destructable.NONE:
                    temp = temperature.NEUTRAL;
                    break;
            }
            
        }
    }
       

}
