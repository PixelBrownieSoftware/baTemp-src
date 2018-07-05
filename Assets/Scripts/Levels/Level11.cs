using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level11 : GameManager {

    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 10;

        advice = "Hang on, this looks quite familiar...";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 30f;

        //P
        tiles[2, 8] = 4;
        tiles[2, 9] = 4;
        tiles[2, 10] = 4;
        tiles[2, 11] = 4;
        tiles[2, 12] = 4;
        tiles[2, 13] = 4;
        tiles[2, 14] = 4;

        tiles[3, 8] = 3;
        tiles[3, 9] = 6;
        tiles[3, 10] = 6;
        tiles[3, 11] = 6;
        tiles[3, 12] = 6;
        tiles[3, 13] = 6;
        tiles[3, 14] = 4;

        tiles[4, 8] = 4;
        tiles[4, 9] = 6;
        tiles[4, 10] = 5;
        tiles[4, 11] = 5;
        tiles[4, 12] = 5;
        tiles[4, 13] = 6;
        tiles[4, 14] = 4;

        tiles[5, 8] = 3;
        tiles[5, 9] = 6;
        tiles[5, 10] = 5;
        tiles[5, 11] = 5;
        tiles[5, 12] = 5;
        tiles[5, 13] = 6;
        tiles[5, 14] = 4;

        tiles[6, 8] = 6;
        tiles[6, 9] = 6;
        tiles[6, 10] = 5;
        tiles[6, 11] = 5;
        tiles[6, 12] = 5;
        tiles[6, 13] = 6;
        tiles[6, 14] = 4;

        tiles[7, 8] = 4;
        tiles[7, 9] = 6;
        tiles[7, 10] = 5;
        tiles[7, 11] = 5;
        tiles[7, 12] = 5;
        tiles[7, 13] = 6;
        tiles[7, 14] = 4;

        tiles[8, 8] = 4;
        tiles[8, 9] = 6;
        tiles[8, 10] = 6;
        tiles[8, 11] = 6;
        tiles[8, 12] = 6;
        tiles[8, 13] = 6;
        tiles[8, 14] = 4;

        tiles[9, 8] = 4;
        tiles[9, 9] = 4;
        tiles[9, 10] = 4;
        tiles[9, 11] = 4;
        tiles[9, 12] = 4;
        tiles[9, 13] = 4;
        tiles[9, 14] = 4;

        tiles[2, 3] = 5;
        tiles[2, 4] = 5;
        tiles[2, 5] = 5;
        tiles[2, 6] = 5;
        tiles[2, 7] = 5;
        tiles[2, 8] = 4;

        tiles[3, 3] = 5;
        tiles[3, 4] = 6;
        tiles[3, 5] = 6;
        tiles[3, 6] = 6;
        tiles[3, 7] = 6;
        tiles[3, 8] = 6;

        tiles[4, 3] = 5;
        tiles[4, 4] = 6;
        tiles[4, 5] = 6;
        tiles[4, 6] = 6;
        tiles[4, 7] = 6;
        tiles[4, 8] = 6;

        tiles[5, 3] = 5;
        tiles[5, 4] = 6;
        tiles[5, 5] = 6;
        tiles[5, 6] = 6;
        tiles[5, 7] = 6;
        tiles[5, 8] = 6;

        tiles[6, 3] = 5;
        tiles[6, 4] = 5;
        tiles[6, 5] = 5;
        tiles[6, 6] = 5;
        tiles[6, 7] = 5;
        tiles[6, 8] = 4;

        //r
        tiles[8, 3] = 5;
        tiles[8, 4] = 5;
        tiles[8, 5] = 5;
        tiles[8, 6] = 5;
        tiles[8, 7] = 5;
        tiles[8, 8] = 4;

        tiles[9, 3] = 5;
        tiles[9, 4] = 5;
        tiles[9, 5] = 3;
        tiles[9, 6] = 3;
        tiles[9, 7] = 3;
        tiles[9, 8] = 4;

        tiles[10, 3] = 5;
        tiles[10, 4] = 5;
        tiles[10, 5] = 5;
        tiles[10, 6] = 5;
        tiles[10, 7] = 3;
        tiles[10, 8] = 4;

        //B
        tiles[11, 3] = 5;
        tiles[11, 4] = 5;
        tiles[11, 5] = 5;
        tiles[11, 6] = 5;
        tiles[11, 7] = 5;
        tiles[11, 8] = 4;
        tiles[11, 9] = 4;
        tiles[11,10] = 4;
        tiles[11,11] = 4;
        tiles[11,12] = 4;
        tiles[11,13] = 4;
        tiles[11,14] = 4;

        tiles[12, 3] = 5;
        tiles[12, 4] = 6;
        tiles[12, 5] = 6;
        tiles[12, 6] = 6;
        tiles[12, 7] = 6;
        tiles[12, 8] = 6;
        tiles[12, 9] = 6;
        tiles[12, 10] = 6;
        tiles[12, 11] = 6;
        tiles[12, 12] = 6;
        tiles[12, 13] = 6;
        tiles[12, 14] = 4;

        tiles[13, 3] = 5;
        tiles[13, 4] = 6;
        tiles[13, 5] = 6;
        tiles[13, 6] = 6;
        tiles[13, 7] = 6;
        tiles[13, 8] = 6;
        tiles[13, 9] = 6;
        tiles[13, 10] = 0;
        tiles[13, 11] = 0;
        tiles[13, 12] = 0;
        tiles[13, 13] = 6;
        tiles[13, 14] = 4;

        tiles[14, 3] = 5;
        tiles[14, 4] = 6;
        tiles[14, 5] = 0;
        tiles[14, 6] = 0;
        tiles[14, 7] = 0;
        tiles[14, 8] = 6;
        tiles[14, 9] = 6;
        tiles[14, 10] = 0;
        tiles[14, 11] = 0;
        tiles[14, 12] = 0;
        tiles[14, 13] = 6;
        tiles[14, 14] = 4;

        tiles[15, 3] = 5;
        tiles[15, 4] = 6;
        tiles[15, 5] = 0;
        tiles[15, 6] = 0;
        tiles[15, 7] = 0;
        tiles[15, 8] = 6;
        tiles[15, 9] = 6;
        tiles[15, 10] = 0;
        tiles[15, 11] = 0;
        tiles[15, 12] = 0;
        tiles[15, 13] = 6;
        tiles[15, 14] = 4;

        tiles[16, 3] = 5;
        tiles[16, 4] = 6;
        tiles[16, 5] = 6;
        tiles[16, 6] = 6;
        tiles[16, 7] = 6;
        tiles[16, 8] = 6;
        tiles[16, 9] = 6;
        tiles[16, 10] = 6;
        tiles[16, 11] = 6;
        tiles[16, 12] = 6;
        tiles[16, 13] = 6;
        tiles[16, 14] = 4;

        tiles[17, 3] = 5;
        tiles[17, 4] = 5;
        tiles[17, 5] = 5;
        tiles[17, 6] = 6;
        tiles[17, 7] = 6;
        tiles[17, 8] = 4;
        tiles[17, 9] = 4;
        tiles[17, 10] = 4;
        tiles[17, 11] = 4;
        tiles[17, 12] = 4;
        tiles[17, 13] = 4;
        tiles[17, 14] = 4;

        //S
        tiles[18, 3] = 5;
        tiles[18, 4] = 6;
        tiles[18, 5] = 6;
        tiles[18, 6] = 6;
        tiles[18, 7] = 0;
        tiles[18, 8] = 6;
        tiles[18, 9] = 6;
        tiles[18, 10] = 6;
        tiles[18, 11] = 6;
        tiles[18, 12] = 6;
        tiles[18, 13] = 6;
        tiles[18, 14] = 4;

        tiles[19, 3] = 5;
        tiles[19, 4] = 6;
        tiles[19, 5] = 6;
        tiles[19, 6] = 6;
        tiles[19, 7] = 0;
        tiles[19, 8] = 6;
        tiles[19, 9] = 6;
        tiles[19, 10] = 6;
        tiles[19, 11] = 0;
        tiles[19, 12] = 6;
        tiles[19, 13] = 6;
        tiles[19, 14] =4;

        tiles[20, 3] = 5;
        tiles[20, 4] = 6;
        tiles[20, 5] = 6;
        tiles[20, 6] = 6;
        tiles[20, 7] = 6;
        tiles[20, 8] = 6;
        tiles[20, 9] = 6;
        tiles[20, 10] = 6;
        tiles[20, 11] = 0;
        tiles[20, 12] = 6;
        tiles[20, 13] = 6;
        tiles[20, 14] = 4;

        tiles[21, 3] = 5;
        tiles[21, 4] = 5;
        tiles[21, 5] = 5;
        tiles[21, 6] = 5;
        tiles[21, 7] = 5;
        tiles[21, 8] = 4;
        tiles[21, 9] = 4;
        tiles[21, 10] = 4;
        tiles[21, 11] = 4;
        tiles[21, 12] = 4;
        tiles[21, 13] = 4;
        tiles[21, 14] = 4;


        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    new void Update()
    {
        base.Update();
    }
}
