using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    protected LevelManager lmanager;

    public string advice;

    public GameObject selectedBlk;
    public TileBlock selectedBlkData;

    public GameObject[] balls;
    public BallScript ball;
    public int[,] tiles;

    public float time_limit;

    public GameObject[] tileObjects;

    public TileBlock[] tileTypes = new TileBlock[7];

    public int ballCnt;
    public int levelId;

    public int xSize = 23;
    public int ySize = 17;
    protected int tileSize = 20;

    public int temperatureBalls;
    public int temperatureBlocks;

    public int temperatrueTotal;


    public void Start () {
        lmanager = GameObject.Find("Levels").GetComponent<LevelManager>();
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");
    }
    

    public void levelGen() {
        temperatureBlocks = 0;
        temperatureBalls = 0;

        if (balls.Length > 0)
        {
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].GetComponent<BallScript>().enabled = true;
                balls[i].GetComponent<BallScript>().temper = BallScript.temperature.NEUTRAL;
                balls[i].GetComponent<BallScript>().transform.position = new Vector2(balls[i].GetComponent<BallScript>().init_X * 20, balls[i].GetComponent<BallScript>().init_Y * 20);
                balls[i].GetComponent<BallScript>().kickstart();
            }
        }

        if (tileObjects.Length == 0)
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int x = 0; x < xSize; x++)
                {
                    TileBlock tt = tileTypes[tiles[x, y]];

                    Instantiate((Resources.Load("Blocks/" + tt.block_name, typeof(GameObject))), new Vector2(x * tileSize, y * tileSize), Quaternion.identity);

                }
            }
        }
        else {
            temperatureBlocks = 0;
            temperatureBalls = 0;

            if (balls.Length > 0)
            {
                for (int i = 0; i < balls.Length; i++)
                {
                    balls[i].GetComponent<BallScript>().enabled = true;
                    balls[i].GetComponent<BallScript>().temper = BallScript.temperature.NEUTRAL;
                    balls[i].GetComponent<BallScript>().transform.position = new Vector2(balls[i].GetComponent<BallScript>().init_X * 20, balls[i].GetComponent<BallScript>().init_Y * 20);
                    balls[i].GetComponent<BallScript>().kickstart();
                }
            }

            for (int i = 0; i < tileObjects.Length; i++)
            {
                TileBlock tileobj = tileObjects[i].GetComponent<TileBlock>();

                TileBlock tt = tileTypes[tiles[tileobj.x, tileobj.y]];

                tileobj.temp = tt.temp;
                tileobj.dest = tt.dest;

                if (tt.temp == TileBlock.temperature.HOT) { temperatureBlocks++; }
                if (tt.temp == TileBlock.temperature.COLD) { temperatureBlocks--; }
            }
            
        }
    }

    public void deleteTiles()
    {
        temperatureBalls = 0;
        temperatureBlocks = 0;
        for (int i = 0; i < tileObjects.Length; i++) {
            tileObjects[i].GetComponent<TileBlock>().dest = TileBlock.destructable.NONE;
            tileObjects[i].GetComponent<TileBlock>().temp = TileBlock.temperature.NEUTRAL;
        }
        if (balls.Length > 0) {
            for (int i = 0; i < balls.Length; i++)
            {
               balls[i].GetComponent<BallScript>().enabled = false;
            }
        }
        
    }

    public int temperatureAddBlocks(GameObject[] obj) {
        
        int coldblocks = 0;
        int hotblocks = 0;
        if (obj.Length > 0)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].GetComponent<TileBlock>().temp == TileBlock.temperature.HOT) { hotblocks++; }
                if (obj[i].GetComponent<TileBlock>().temp == TileBlock.temperature.COLD) { coldblocks++; }
            }
        }

        return hotblocks - coldblocks;
    }



    // Update is called once per frame
    public void Update () {

        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");
        foreach (Transform child in transform)
        {
            balls = GameObject.FindGameObjectsWithTag("Ball");
        }
        

        temperatureBlocks = temperatureAddBlocks(tileObjects);

        temperatrueTotal = temperatureBalls + temperatureBlocks;
        
        
    }
}
