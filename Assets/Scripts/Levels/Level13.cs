using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level13 : GameManager {

    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 12;

        advice = "Try to neutralize these ball prisoners, or even free them!";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 36f;

        tiles[ 4, 4] = 6;
        tiles[4, 5] = 6;
        tiles[4, 6] = 6;
        tiles[4, 7] = 5;
        tiles[4, 8] = 6;
        tiles[4, 9] = 6;
        tiles[4,10] = 6;
        tiles[4, 11] = 5;
        tiles[4,12] = 6;
        tiles[4,13] = 6;
        tiles[4,14] = 6;

        tiles[5, 4] = 6;
        tiles[5, 5] = 6;
        tiles[5, 6] = 6;
        tiles[5, 7] = 2;
        tiles[5, 8] = 6;
        tiles[5, 9] = 6;
        tiles[5, 10] = 6;
        tiles[5, 11] = 5;
        tiles[5, 12] = 6;
        tiles[5, 13] = 6;
        tiles[5, 14] = 6;

        tiles[6, 4] = 6;
        tiles[6, 5] = 6;
        tiles[6, 6] = 6;
        tiles[6, 7] = 2;
        tiles[6, 8] = 6;
        tiles[6, 9] = 6;
        tiles[6, 10] = 6;
        tiles[6, 11] = 5;
        tiles[6, 12] = 6;
        tiles[6, 13] = 6;
        tiles[6, 14] = 6;

        tiles[7, 4] = 6;
        tiles[7, 5] =06;
        tiles[7, 6] = 6;
        tiles[7, 7] = 5;
        tiles[7, 8] = 6;
        tiles[7, 9] = 6;
        tiles[7, 10] = 6;
        tiles[7, 11] = 5;
        tiles[7, 12] = 0;
        tiles[7, 13] = 0;
        tiles[7, 14] = 0;

        tiles[8, 4] = 6;
        tiles[8, 5] = 6;
        tiles[8, 6] = 6;
        tiles[8, 7] = 5;
        tiles[8, 8] = 6;
        tiles[8, 9] = 6;
        tiles[8, 10] = 6;
        tiles[8, 11] = 5;
        tiles[8, 12] = 6;
        tiles[8, 13] = 6;
        tiles[8, 14] = 6;

        tiles[9, 4] = 0;
        tiles[9, 5] = 0;
        tiles[9, 6] = 0;
        tiles[9, 7] = 5;
        tiles[9, 8] = 6;
        tiles[9, 9] = 6;
        tiles[9, 10] = 6;
        tiles[9, 11] = 5;
        tiles[9, 12] = 6;
        tiles[9, 13] = 6;
        tiles[9, 14] = 6;

        tiles[10, 4] = 6;
        tiles[10, 5] = 6;
        tiles[10, 6] = 6;
        tiles[10, 7] = 5;
        tiles[10, 8] = 6;
        tiles[10, 9] = 6;
        tiles[10, 10] = 6;
        tiles[10, 11] = 5;
        tiles[10, 12] = 0;
        tiles[10, 13] = 0;
        tiles[10, 14] = 0;

        tiles[11, 4] = 6;
        tiles[11, 5] = 6;
        tiles[11, 6] = 6;
        tiles[11, 7] = 5;
        tiles[11, 8] = 6;
        tiles[11, 9] = 6;
        tiles[11, 10] = 6;
        tiles[11, 11] = 5;
        tiles[11, 12] = 6;
        tiles[11, 13] = 6;
        tiles[11, 14] = 6;

        tiles[12, 4] = 6;
        tiles[12, 5] = 6;
        tiles[12, 6] = 6;
        tiles[12, 7] = 1;
        tiles[12, 8] = 6;
        tiles[12, 9] = 6;
        tiles[12, 10] = 6;
        tiles[12, 11] = 2;
        tiles[12, 12] = 6;
        tiles[12, 13] = 6;
        tiles[12, 14] = 6;

        tiles[13, 4] = 6;
        tiles[13, 5] = 6;
        tiles[13, 6] = 6;
        tiles[13, 7] = 2;
        tiles[13, 8] = 6;
        tiles[13, 9] = 6;
        tiles[13, 10] = 6;
        tiles[13, 11] = 1;
        tiles[13, 12] = 6;
        tiles[13, 13] = 6;
        tiles[13, 14] = 6;

        tiles[14, 4] = 0;
        tiles[14, 5] = 0;
        tiles[14, 6] = 0;
        tiles[14, 7] = 5;
        tiles[14, 8] = 6;
        tiles[14, 9] = 6;
        tiles[14, 10] = 6;
        tiles[14, 11] = 4;
        tiles[14, 12] = 0;
        tiles[14, 13] = 0;
        tiles[14, 14] = 0;

        tiles[15, 4] = 6;
        tiles[15, 5] = 6;
        tiles[15, 6] = 6;
        tiles[15, 7] = 5;
        tiles[15, 8] = 6;
        tiles[15, 9] = 6;
        tiles[15, 10] = 6;
        tiles[15, 11] = 4;
        tiles[15, 12] = 6;
        tiles[15, 13] = 6;
        tiles[15, 14] = 6;

        tiles[16, 4] = 6;
        tiles[16, 5] = 6;
        tiles[16, 6] = 6;
        tiles[16, 7] = 5;
        tiles[16, 8] = 6;
        tiles[16, 9] = 6;
        tiles[16, 10] = 6;
        tiles[16, 11] = 4;
        tiles[16, 12] = 6;
        tiles[16, 13] = 6;
        tiles[16, 14] = 6;

        tiles[17, 4] = 6;
        tiles[17, 5] = 6;
        tiles[17, 6] = 6;
        tiles[17, 7] = 5;
        tiles[17, 8] = 6;
        tiles[17, 9] = 6;
        tiles[17, 10] = 6;
        tiles[17, 11] = 4;
        tiles[17, 12] = 6;
        tiles[17, 13] = 6;
        tiles[17, 14] = 6;

        tiles[18, 4] = 6;
        tiles[18, 5] = 6;
        tiles[18, 6] = 6;
        tiles[18, 7] = 5;
        tiles[18, 8] = 6;
        tiles[18, 9] = 6;
        tiles[18, 10] = 6;
        tiles[18, 11] = 4;
        tiles[18, 12] = 6;
        tiles[18, 13] = 6;
        tiles[18, 14] = 6;




        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    new void Update()
    {
        base.Update();
    }
}
