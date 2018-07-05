﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level14 : GameManager {

    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 13;

        advice = "Null";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 27f;

        tiles[7, 9] = 4;
        tiles[7,10] = 5;
        tiles[7,11] = 5;
        tiles[7,12] = 5;
        tiles[7,13] = 5;
        tiles[7,14] = 5;
        tiles[7, 15] = 4;

        tiles[8, 9] = 5;
        tiles[8, 10] = 6;
        tiles[8, 11] = 6;
        tiles[8, 12] = 6;
        tiles[8, 13] = 6;
        tiles[8, 14] = 6;
        tiles[8, 15] = 5;

        tiles[9, 9] = 5;
        tiles[9, 10] = 6;
        tiles[9, 11] = 6;
        tiles[9, 12] = 6;
        tiles[9, 13] = 6;
        tiles[9, 14] = 6;
        tiles[9, 15] = 5;

        tiles[10, 9] = 5;
        tiles[10, 10] = 6;
        tiles[10, 11] = 6;
        tiles[10, 12] = 6;
        tiles[10, 13] = 6;
        tiles[10, 14] = 6;
        tiles[10, 15] = 5;

        tiles[11, 9] = 6;
        tiles[11, 10] = 6;
        tiles[11, 11] = 6;
        tiles[11, 12] = 6;
        tiles[11, 13] = 6;
        tiles[11, 14] = 6;
        tiles[11, 15] = 5;

        tiles[12, 9] = 6;
        tiles[12, 10] = 6;
        tiles[12, 11] = 6;
        tiles[12, 12] = 6;
        tiles[12, 13] = 6;
        tiles[12, 14] = 6;
        tiles[12, 15] = 5;

        tiles[13, 9] = 6;
        tiles[13, 10] = 6;
        tiles[13, 11] = 6;
        tiles[13, 12] = 6;
        tiles[13, 13] = 6;
        tiles[13, 14] = 6;
        tiles[13, 15] = 5;

        tiles[14, 9] = 5;
        tiles[14, 10] = 6;
        tiles[14, 11] = 6;
        tiles[14, 12] = 6;
        tiles[14, 13] = 6;
        tiles[14, 14] = 6;
        tiles[14, 15] = 5;

        tiles[15, 9] = 5;
        tiles[15, 10] = 6;
        tiles[15, 11] = 6;
        tiles[15, 12] = 6;
        tiles[15, 13] = 6;
        tiles[15, 14] = 6;
        tiles[15, 15] = 5;

        tiles[16, 9] = 5;
        tiles[16, 10] = 6;
        tiles[16, 11] = 6;
        tiles[16, 12] = 6;
        tiles[16, 13] = 6;
        tiles[16, 14] = 6;
        tiles[16, 15] = 5;

        tiles[17, 9] = 4;
        tiles[17, 10] = 5;
        tiles[17, 11] = 6;
        tiles[17, 12] = 6;
        tiles[17, 13] = 6;
        tiles[17, 14] = 5;
        tiles[17, 15] = 4;

        //middle
        tiles[14, 8] = 5;
        tiles[13, 8] = 3;
        tiles[12, 8] = 3;
        tiles[11, 8] = 3;
        tiles[10, 8] = 5;

        tiles[14, 7] = 5;
        tiles[13, 7] = 3;
        tiles[12, 7] = 3;
        tiles[11, 7] = 3;
        tiles[10, 7] = 5;

        //bottom bit

        tiles[7, 4] = 4;
        tiles[8, 4] = 6;
        tiles[9, 4] = 6;
        tiles[10, 4] = 6;
        tiles[11, 4] = 6;
        tiles[12, 4] = 6;
        tiles[13, 4] = 4;
        tiles[14, 4] = 6;
        tiles[15, 4] = 5;
        tiles[16, 4] = 4;
        tiles[17, 4] = 6;

        tiles[7, 5] = 6;
        tiles[8, 5] = 6;
        tiles[9, 5] = 6;
        tiles[10, 5] = 6;
        tiles[11, 5] = 6;
        tiles[12, 5] = 6;
        tiles[13, 5] = 6;
        tiles[14, 5] = 6;
        tiles[15, 5] = 6;
        tiles[16, 5] = 6;
        tiles[17, 5] = 6;

        tiles[7, 6] = 6;
        tiles[8, 6] = 6;
        tiles[9, 6] = 6;
        tiles[10, 6] = 6;
        tiles[11, 6] = 6;
        tiles[12, 6] = 6;
        tiles[13, 6] = 6;
        tiles[14, 6] = 6;
        tiles[15, 6] = 6;
        tiles[16, 6] = 6;
        tiles[17, 6] = 6;

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    new void Update()
    {
        base.Update();
    }
}
