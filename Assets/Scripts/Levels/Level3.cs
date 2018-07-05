using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level3 : GameManager {
    
	new void Start()
    {

        levelId = 2;

        advice = "Null";

        time_limit = 14f;

        tiles = new int[xSize, ySize];

        base.Start();

        tiles[4, 8] = 6;
        tiles[4, 9] = 6;
        tiles[4, 10] = 2;
        tiles[4, 11] = 6;
        tiles[4, 12] = 2;

        tiles[5, 8] = 6;
        tiles[5, 9] = 1;
        tiles[5, 10] = 6;
        tiles[5, 11] = 2;
        tiles[5, 12] = 2;

        tiles[6, 8] = 3;
        tiles[6, 9] = 6;
        tiles[6, 10] = 6;
        tiles[6, 11] = 6;
        tiles[6, 12] = 2;

        tiles[7, 8] = 3;
        tiles[7, 9] = 6;
        tiles[7, 10] = 6;
        tiles[7, 11] = 3;
        tiles[7, 12] = 1;


        tiles[8, 8] = 1;
        tiles[8, 9] = 1;
        tiles[8, 10] = 3;
        tiles[8, 11] = 1;
        tiles[8, 12] = 1;

        tiles[9, 8] = 1;
        tiles[9, 9] = 6;
        tiles[9, 10] = 1;
        tiles[9, 11] = 1;
        tiles[9, 12] = 3;
        tiles[9, 13] = 3;
        tiles[9, 14] = 6;
        tiles[9, 15] = 1;

        tiles[10, 8] = 1;
        tiles[10, 9] = 1;
        tiles[10, 10] = 3;
        tiles[10, 11] = 3;
        tiles[10, 12] = 1;
        tiles[10, 13] = 6;
        tiles[10, 14] = 6;
        tiles[10, 15] = 1;

        tiles[11, 8] = 3;
        tiles[11, 9] = 1;
        tiles[11, 10] = 6;
        tiles[11, 11] = 1;
        tiles[11, 12] = 3;
        tiles[13, 13] = 1;
        tiles[13, 14] = 6;
        tiles[13, 15] = 2;

        tiles[12, 8] = 3;
        tiles[12, 9] = 1;
        tiles[12, 10] = 1;
        tiles[12, 11] = 1;
        tiles[12, 12] = 6;
        tiles[12, 13] = 1;
        tiles[12, 14] = 6;
        tiles[12, 15] = 6;

        tiles[13, 8] = 6;
        tiles[13, 9] = 1;
        tiles[13, 10] = 1;
        tiles[13, 11] = 6;
        tiles[13, 12] = 1;
        tiles[13, 13] = 1;
        tiles[13, 14] = 6;
        tiles[13, 15] = 1;






        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }
	
	// Update is called once per frame
	new void Update ()
    {
        
        base.Update();
	}
}
