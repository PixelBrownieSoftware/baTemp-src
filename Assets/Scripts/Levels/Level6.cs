using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level6 : GameManager {
    
	new void Start () {

        levelId = 5;

        advice = "Maybe neutral blocks could help you to block the ball from going elsewhere. Could give you an opportunity to change its temperature.";

        tiles = new int[xSize, ySize];

        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        base.Start();

        

        time_limit = 24f;

        tiles[3, 2] = 6;
        tiles[3, 3] = 6;
        tiles[3, 4] = 6;
        tiles[3, 5] = 2;
        tiles[3, 6] = 6;
        tiles[3, 7] = 6;

        tiles[4, 2] = 6;
        tiles[4, 3] = 6;
        tiles[4, 4] = 6;
        tiles[4, 5] = 2;
        tiles[4, 6] = 6;
        tiles[4, 7] = 6;

        tiles[5, 2] = 6;
        tiles[5, 3] = 6;
        tiles[5, 4] = 6;
        tiles[5, 5] = 2;
        tiles[5, 6] = 6;
        tiles[5, 7] = 6;

        tiles[6, 2] = 6;
        tiles[6, 3] = 6;
        tiles[6, 4] = 6;
        tiles[6, 5] = 2;
        tiles[6, 6] = 6;
        tiles[6, 7] = 6;

        tiles[7, 2] = 6;
        tiles[7, 3] = 6;
        tiles[7, 4] = 6;
        tiles[7, 5] = 2;
        tiles[7, 6] = 6;
        tiles[7, 7] = 6;

        tiles[8, 2] = 6;
        tiles[8, 3] = 6;
        tiles[8, 4] = 6;
        tiles[8, 5] = 2;
        tiles[8, 6] = 6;
        tiles[8, 7] = 6;
        
        tiles[9, 6] = 6;
        tiles[9, 7] = 6;

        tiles[10, 13] = 6;
        tiles[10, 12] = 6;
        tiles[10, 11] = 6;
        tiles[10, 10] = 6;
        tiles[10, 9] = 6;
        tiles[10, 8] = 6;
        tiles[10, 7] = 6;
        tiles[10, 6] = 6;

        tiles[11, 13] = 6;
        tiles[11, 12] = 6;
        tiles[11, 11] = 6;
        tiles[11, 10] = 6;
        tiles[11, 9] = 6;
        tiles[11, 8] = 6;
        tiles[11, 7] = 6;
        tiles[11, 6] = 6;

        tiles[12, 13] = 2;
        tiles[12, 12] = 2;
        tiles[12, 11] = 2;
        tiles[12, 10] = 2;
        tiles[12, 9] = 6;
        tiles[12, 8] = 6;
        tiles[12, 7] = 6;
        tiles[12, 6] = 6;


        tiles[13, 13] = 6;
        tiles[13, 12] = 6;
        tiles[13, 11] = 6;
        tiles[13, 10] = 2;
        tiles[13, 9] = 6;
        tiles[13, 8] = 6;
        tiles[13, 7] = 6;
        tiles[13, 6] = 6;

        tiles[14, 13] = 6;
        tiles[14, 12] = 6;
        tiles[14, 11] = 6;
        tiles[14, 10] = 2;
        tiles[14, 9] = 1;
        tiles[14, 8] = 1;
        tiles[14, 7] = 1;
        tiles[14, 6] = 1;


        tiles[15, 13] = 6;
        tiles[15, 12] = 6;
        tiles[15, 11] = 6;
        tiles[15, 10] = 2;
        tiles[15, 9] = 1;
        tiles[15, 8] = 1;
        tiles[15, 7] = 1;
        tiles[15, 6] = 1;

        tiles[16, 13] = 6;
        tiles[16, 12] = 6;
        tiles[16, 11] = 6;
        tiles[16, 10] = 2;
        tiles[16, 9] = 1;
        tiles[16, 8] = 1;
        tiles[16, 7] = 1;
        tiles[16, 6] = 1;

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }
	
	// Update is called once per frame
	new void Update () {
        base.Update();
	}
}
