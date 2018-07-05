using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cursor : MonoBehaviour {

    public int tileLength;
    private int cursorpos_x;
    private int cursorpos_y;

    private SoundManager sfx;

    public bool canPlace;

    private GameManager Gmanager;

    public GameObject[] blockType;
    public int selectedBlock;

    // Use this for initialization
    void Start() {

        canPlace = true;
        Gmanager = GameObject.FindGameObjectWithTag("Level").GetComponent<GameManager>();
        selectedBlock = 0;
        sfx = GameObject.Find("SFX manager").GetComponent<SoundManager>();
	}

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            canPlace = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            canPlace = true;
        }
    }


    void Update () {
        

        //  cursorpos_x = (Mathf.RoundToInt(Input.mousePosition.x) / tileLength);
        //  cursorpos_y = (Mathf.RoundToInt(Input.mousePosition.y) / tileLength);

        if (buttonDown() ) {
            cursorpos_y += Mathf.FloorToInt(Input.GetAxisRaw("Vertical"));
            cursorpos_x += Mathf.FloorToInt (Input.GetAxisRaw("Horizontal"));
        }

        cursorpos_x = Mathf.Clamp(cursorpos_x, 0, Gmanager.xSize - 1);
        cursorpos_y = Mathf.Clamp(cursorpos_y, 0, Gmanager.ySize - 1);

        //creating blocks
        if (Input.GetKeyDown(KeyCode.Z)  && canPlace) {

            for (int i = 0; i < Gmanager.tileObjects.Length; i++)
            {
                if (cursorpos_y == Gmanager.tileObjects[i].GetComponent<TileBlock>().y && cursorpos_x == Gmanager.tileObjects[i].GetComponent<TileBlock>().x)
                {
                    Gmanager.selectedBlk = Gmanager.tileObjects[i];
                    Gmanager.selectedBlkData = Gmanager.selectedBlk.GetComponent<TileBlock>();                         
                    //sorry for the shit code it took me all day to figure this out, but it worked and was more efficent than deleting the objects
                    if ((Gmanager.selectedBlkData.temp == TileBlock.temperature.NEUTRAL) && ( Gmanager.selectedBlkData.dest == TileBlock.destructable.NONE) && (Gmanager.selectedBlkData.id != Mathf.Clamp(Gmanager.selectedBlkData.id, 1, 4)))
                        {
                        Gmanager.selectedBlkData.temp = blockType[selectedBlock].GetComponent<TileBlock>().temp;
                        Gmanager.selectedBlkData.dest = blockType[selectedBlock].GetComponent<TileBlock>().dest;
                        Gmanager.selectedBlkData.block_name = blockType[selectedBlock].GetComponent<TileBlock>().block_name;
                        if (selectedBlock == 2) { sfx.PlacingIceBlock.Play(); }
                        if (selectedBlock == 1) { sfx.PlacingFireBlock.Play(); }
                    }

                }
            }
        }

        //deleting blocks
        if (Input.GetKeyDown(KeyCode.X) && canPlace)
        {
            for (int i = 0; i < Gmanager.tileObjects.Length; i++)
            {
                if (cursorpos_y == Gmanager.tileObjects[i].GetComponent<TileBlock>().y && cursorpos_x == Gmanager.tileObjects[i].GetComponent<TileBlock>().x)
                {
                    Gmanager.selectedBlk = Gmanager.tileObjects[i];
                    Gmanager.selectedBlkData = Gmanager.selectedBlk.GetComponent<TileBlock>();

                    if ( Gmanager.tileObjects[i].GetComponent<TileBlock>().dest == TileBlock.destructable.BREAKABLE && (Gmanager.selectedBlkData.id == Mathf.Clamp(Gmanager.selectedBlkData.id, 1, 3)))
                    {
                        Gmanager.selectedBlkData.temp = blockType[3].GetComponent<TileBlock>().temp;
                        Gmanager.selectedBlkData.dest = blockType[3].GetComponent<TileBlock>().dest;
                        Gmanager.selectedBlkData.block_name = blockType[3].GetComponent<TileBlock>().block_name;
                        sfx.RemoveBlock.Play();
                    }
                }
            }
        }

        //going through blocks
        if (Input.GetKeyDown(KeyCode.A)) { selectedBlock++; }
        if (Input.GetKeyDown(KeyCode.S)) { selectedBlock--; }

        selectedBlock = Mathf.Clamp(selectedBlock, 0, 2);

        transform.position = new Vector2(cursorpos_x * tileLength, cursorpos_y * tileLength);

	}

    public bool buttonDown() {
        return Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical");
    }

}
