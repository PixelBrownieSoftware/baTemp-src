using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level5 : GameManager {

	// Use this for initialization
	new void Start () {

        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 4;

        advice = "Try putting ice blocks behind the heat blocks. Oh, and remove those heat blocks once the ball hits the ice blocks.";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 25f;

        tiles[5, 8] = 6;
        tiles[5, 9] = 6;
        tiles[5, 10] = 6;
        tiles[5, 11] = 6;
        tiles[6, 8] = 6;
        tiles[6, 9] = 6;
        tiles[6, 10] = 6;
        tiles[6, 11] = 6;
        tiles[7, 8] = 6;
        tiles[7, 9] = 6;
        tiles[7, 10] = 6;
        tiles[7, 11] = 6;
        tiles[8, 8] = 2;
        tiles[8, 9] = 2;
        tiles[8, 10] = 2;
        tiles[8, 11] = 2;

        tiles[9, 8] = 6;
        tiles[9, 9] = 6;
        tiles[9, 10] = 6;
        tiles[9, 11] = 6;

        tiles[10, 8] = 6;
        tiles[10, 9] = 6;
        tiles[10, 10] = 6;
        tiles[10, 11] = 6;

        tiles[11, 8] = 6;
        tiles[11, 9] = 6;
        tiles[11, 10] = 6;
        tiles[11, 11] = 6;

        tiles[12, 8] = 6;
        tiles[12, 9] = 6;
        tiles[12, 10] = 6;
        tiles[12, 11] = 6;

        tiles[13, 8] = 6;
        tiles[13, 9] = 6;
        tiles[13, 10] = 6;
        tiles[13, 11] = 6;

        tiles[14, 8] = 6;
        tiles[14, 9] = 6;
        tiles[14, 10] = 6;
        tiles[14, 11] = 6;

        tiles[15, 8] = 2;
        tiles[15, 9] = 2;
        tiles[15, 10] = 2;
        tiles[15, 11] = 2;

        tiles[16, 8] = 6;
        tiles[16, 9] = 6;
        tiles[16, 10] = 6;
        tiles[16, 11] = 6;

        tiles[17, 8] = 6;
        tiles[17, 9] = 6;
        tiles[17, 10] = 6;
        tiles[17, 11] = 6;

        tiles[18, 8] = 6;
        tiles[18, 9] = 6;
        tiles[18, 10] = 6;
        tiles[18, 11] = 6;

        tiles[19, 8] = 6;
        tiles[19, 9] = 6;
        tiles[19, 10] = 6;
        tiles[19, 11] = 6;

        //bottom block
        tiles[9, 4] = 6;
        tiles[9, 5] = 6;
        tiles[9, 6] = 6;
        tiles[9, 7] = 2;

        tiles[10, 4] = 6;
        tiles[10, 5] = 6;
        tiles[10, 6] = 6;
        tiles[10, 7] = 2;

        tiles[11, 4] = 6;
        tiles[11, 5] = 6;
        tiles[11, 6] = 6;
        tiles[11, 7] = 2;

        tiles[12, 4] = 6;
        tiles[12, 5] = 6;
        tiles[12, 6] = 6;
        tiles[12, 7] = 2;

        tiles[13, 4] = 6;
        tiles[13, 5] = 6;
        tiles[13, 6] = 6;
        tiles[13, 7] = 2;

        tiles[14, 4] = 6;
        tiles[14, 5] = 6;
        tiles[14, 6] = 6;
        tiles[14, 7] = 2;

        //upper block
        tiles[9, 12] = 2;
        tiles[9, 13] = 6;
        tiles[9, 14] = 6;
        tiles[9, 15] = 6;

        tiles[10, 12] = 2;
        tiles[10, 13] = 6;
        tiles[10, 14] = 6;
        tiles[10, 15] = 6;

        tiles[11, 12] = 2;
        tiles[11, 13] = 6;
        tiles[11, 14] = 6;
        tiles[11, 15] = 6;

        tiles[12, 12] = 2;
        tiles[12, 13] = 6;
        tiles[12, 14] = 6;
        tiles[12, 15] = 6;

        tiles[13, 12] = 2;
        tiles[13, 13] = 6;
        tiles[13, 14] = 6;
        tiles[13, 15] = 6;

        tiles[14, 12] = 2;
        tiles[14, 13] = 6;
        tiles[14, 14] = 6;
        tiles[14, 15] = 6;

        //ball1 11, 13

        //ball2 7, 9

        if (lmanager.level == levelId) { lmanager.time = time_limit;levelGen(); }
    }
	
	// Update is called once per frame
	new void Update () {
        base.Update();
	}
}
