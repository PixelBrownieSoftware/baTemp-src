using UnityEngine;
using System.Collections;

public class BatScript : MonoBehaviour {

    private float speed;
    private GameObject cursor;
    public SpriteRenderer rend;

	// Use this for initialization
	void Start () {
        speed = 20f;
        cursor = GameObject.Find("Cursor");
    }
	
	// Update is called once per frame
	void Update () {
        float time = 170f;
        float mov = speed/time;

        transform.position = Vector2.Lerp(transform.position, cursor.transform.position, mov );

        if (cursor.GetComponent<Cursor>().selectedBlock == 0) { rend.color = new Color(1F, 1F, 1F, 1F); }

        if (cursor.GetComponent<Cursor>().selectedBlock == 2) { rend.color = new Color(0.2F, 0.2F, 0.7F, 1F); }
        if (cursor.GetComponent<Cursor>().selectedBlock == 1) { rend.color= new Color(0.7F, 0.3F, 0.4F, 1F); }
    }
}
