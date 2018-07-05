using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level7 : GameManager {

    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 6;

        advice = "You can't destory lava. I wonder how you would solve THIS one...";

        time_limit = 20f;

        tiles = new int[xSize, ySize];

        base.Start();

        tiles[5,4] = 6;
        tiles[5,5] = 6;
        tiles[5, 6] = 6;
        tiles[5, 7] = 6;
        tiles[5, 8] = 6;
        tiles[5, 9] = 6;
        tiles[5, 10] = 6;
        tiles[5, 11] = 6;
        tiles[5, 12] = 6;
        tiles[5, 13] = 6;
        tiles[5, 14] = 6;

        tiles[6, 4] = 6;
        tiles[6, 5] = 6;
        tiles[6, 6] = 6;
        tiles[6, 7] = 6;
        tiles[6, 8] = 6;
        tiles[6, 9] = 6;
        tiles[6, 10] = 6;
        tiles[6, 11] = 6;
        tiles[6, 12] = 6;
        tiles[6, 13] = 6;
        tiles[6, 14] = 6;

        tiles[7, 4] = 6;
        tiles[7, 5] = 6;
        tiles[7, 6] = 6;
        tiles[7, 7] = 6;
        tiles[7, 8] = 6;
        tiles[7, 9] = 6;
        tiles[7, 10] = 6;
        tiles[7, 11] = 6;
        tiles[7, 12] = 6;
        tiles[7, 13] = 6;
        tiles[7, 14] = 6;

        tiles[8, 4] = 6;
        tiles[8, 5] = 6;
        tiles[8, 6] = 6;
        tiles[8, 7] = 6;
        tiles[8, 8] = 6;
        tiles[8, 9] = 6;
        tiles[8, 10] = 6;
        tiles[8, 11] = 6;
        tiles[8, 12] = 6;
        tiles[8, 13] = 6;
        tiles[8, 14] = 6;

        tiles[9, 4] = 6;
        tiles[9, 5] = 6;
        tiles[9, 6] = 6;
        tiles[9, 7] = 6;
        tiles[9, 8] = 6;
        tiles[9, 9] = 6;
        tiles[9, 10] = 6;
        tiles[9, 11] = 6;
        tiles[9, 12] = 6;
        tiles[9, 13] = 6;
        tiles[9, 14] = 6;

        tiles[10, 4] = 6;
        tiles[10, 5] = 6;
        tiles[10, 6] = 6;
        tiles[10, 7] = 6;
        tiles[10, 8] = 6;
        tiles[10, 9] = 6;
        tiles[10, 10] = 6;
        tiles[10, 11] = 6;
        tiles[10, 12] = 6;
        tiles[10, 13] = 6;
        tiles[10, 14] = 6;

        //lava batch

        tiles[11, 4] = 4;
        tiles[11, 5] = 4;
        tiles[11, 6] = 4;
        tiles[11, 7] = 4;
        tiles[11, 8] = 4;
        tiles[11, 9] = 4;
        tiles[11, 10] = 4;
        tiles[11, 11] = 4;
        tiles[11, 12] = 4;
        tiles[11, 13] = 4;
        tiles[11, 14] = 4;

        tiles[12, 4] = 3;
        tiles[12, 5] = 3;
        tiles[12, 6] = 3;
        tiles[12, 7] = 3;
        tiles[12, 8] = 3;
        tiles[12, 9] = 3;
        tiles[12, 10] = 3;
        tiles[12, 11] = 3;
        tiles[12, 12] = 3;
        tiles[12, 13] = 3;
        tiles[12, 14] = 3;

        tiles[13, 4] = 4;
        tiles[13, 5] = 4;
        tiles[13, 6] = 4;
        tiles[13, 7] = 4;
        tiles[13, 8] = 4;
        tiles[13, 9] = 4;
        tiles[13, 10] =4;
        tiles[13, 11] = 4;
        tiles[13, 12] = 4;
        tiles[13, 13] = 4;
        tiles[13, 14] = 4;

        tiles[14, 4] = 6;
        tiles[14, 5] = 6;
        tiles[14, 6] = 6;
        tiles[14, 7] = 6;
        tiles[14, 8] = 6;
        tiles[14, 9] = 6;
        tiles[14, 10] = 6;
        tiles[14, 11] = 6;
        tiles[14, 12] = 6;
        tiles[14, 13] = 6;
        tiles[14, 14] = 6;

        tiles[15, 4] = 6;
        tiles[15, 5] = 6;
        tiles[15, 6] = 6;
        tiles[15, 7] = 6;
        tiles[15, 8] = 6;
        tiles[15, 9] = 6;
        tiles[15, 10] = 6;
        tiles[15, 11] = 6;
        tiles[15, 12] = 6;
        tiles[15, 13] = 6;
        tiles[15, 14] = 6;

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
        tiles[16, 14] = 6;

        tiles[17, 4] = 6;
        tiles[17, 5] = 6;
        tiles[17, 6] = 6;
        tiles[17, 7] = 6;
        tiles[17, 8] = 6;
        tiles[17, 9] = 6;
        tiles[17, 10] = 6;
        tiles[17, 11] = 6;
        tiles[17, 12] = 6;
        tiles[17, 13] = 6;
        tiles[17, 14] = 6;

        tiles[18, 4] = 6;
        tiles[18, 5] = 6;
        tiles[18, 6] = 6;
        tiles[18, 7] = 6;
        tiles[18, 8] = 6;
        tiles[18, 9] = 6;
        tiles[18, 10] = 6;
        tiles[18, 11] = 6;
        tiles[18, 12] = 6;
        tiles[18, 13] = 6;
        tiles[18, 14] = 6;

        tiles[19, 4] = 6;
        tiles[19, 5] = 6;
        tiles[19, 6] = 6;
        tiles[19, 7] = 6;
        tiles[19, 8] = 6;
        tiles[19, 9] = 6;
        tiles[19, 10] = 6;
        tiles[19, 11] = 6;
        tiles[19, 12] = 6;
        tiles[19, 13] = 6;
        tiles[19, 14] = 6;

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
