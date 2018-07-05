using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level2 : GameManager {

    new void Start ()
    {
        levelId = 1;

        advice = " Now it's under -10°C! From the previous level, you probably know which blocks to remove now...";

        base.Start();

        tiles = new int[xSize, ySize];

        time_limit = 15f;

        //1st block
        tiles[4, 3] = 2;
        tiles[4, 4] = 1;
        tiles[4, 5] = 2;
        tiles[4, 6] = 2;
        tiles[4, 7] = 2;
        tiles[5, 3] = 2;
        tiles[5, 4] = 2;
        tiles[5, 5] = 2;
        tiles[5, 6] = 2;
        tiles[5, 7] = 2;
        tiles[6, 3] = 6;
        tiles[6, 4] = 6;
        tiles[6, 5] = 1;
        tiles[6, 6] = 3;
        tiles[6, 7] = 3;
        tiles[7, 3] = 3;
        tiles[7, 4] = 3;
        tiles[7, 5] = 3;
        tiles[7, 6] = 2;
        tiles[7, 7] = 3;
        tiles[8, 3] = 1;
        tiles[8, 4] = 1;
        tiles[8, 5] = 3;
        tiles[8, 6] = 6;
        tiles[8, 7] = 6;
        tiles[9, 3] = 6;
        tiles[9, 4] = 6;
        tiles[9, 5] = 1;
        tiles[9, 6] = 1;
        tiles[9, 7] = 6;
        tiles[10, 3] = 6;
        tiles[10, 4] = 6;
        tiles[10, 5] = 1;
        tiles[10, 6] = 1;
        tiles[10, 7] = 6;
        tiles[11, 3] = 6;
        tiles[11, 4] = 1;
        tiles[11, 5] = 6;
        tiles[11, 6] = 6;
        tiles[11, 7] = 6;
        tiles[12, 3] = 6;
        tiles[12, 4] = 6;
        tiles[12, 5] = 6;
        tiles[12, 6] = 1;
        tiles[12, 7] = 6;
        tiles[13, 3] = 6;
        tiles[13, 4] = 1;
        tiles[13, 5] = 6;
        tiles[13, 6] = 6;
        tiles[13, 7] = 6;
        tiles[14, 3] = 6;
        tiles[14, 4] = 6;
        tiles[14, 5] = 6;
        tiles[14, 6] = 1;
        tiles[14, 7] = 6;
        tiles[15, 3] = 1;
        tiles[15, 4] = 2;
        tiles[15, 5] = 1;
        tiles[15, 6] = 2;
        tiles[15, 7] = 6;

        //2nd block
        tiles[19, 3] = 6;
        tiles[19, 4] = 6;
        tiles[19, 5] = 6;
        tiles[19, 6] = 6;
        tiles[19, 7] = 6;
        tiles[19, 8] = 1;
        tiles[20, 3] = 6;
        tiles[20, 4] = 1;
        tiles[20, 5] = 1;
        tiles[20, 6] = 2;
        tiles[20, 7] = 6;
        tiles[20, 8] = 6;
        tiles[21, 3] = 1;
        tiles[21, 4] = 6;
        tiles[21, 5] = 1;
        tiles[21, 6] = 6;
        tiles[21, 7] = 6;
        tiles[21, 8] = 1;

        //3rd block
        tiles[6, 11] = 1;
        tiles[6, 12] = 6;
        tiles[6, 13] = 1;
        tiles[6, 14] = 6;
        tiles[7, 11] = 6;
        tiles[7, 12] = 1;
        tiles[7, 13] = 6;
        tiles[7, 14] = 1;
        tiles[8, 11] = 1;
        tiles[8, 12] = 6;
        tiles[8, 13] = 6;
        tiles[8, 14] = 6;
        tiles[9, 11] = 6;
        tiles[9, 12] = 1;
        tiles[9, 13] = 6;
        tiles[9, 14] = 1;
        tiles[10, 11] = 6;
        tiles[10, 12] = 1;
        tiles[10, 13] = 6;
        tiles[10, 14] = 6;

        //4th block
        tiles[14, 11] = 1;
        tiles[14, 12] = 6;
        tiles[14, 13] = 6;
        tiles[14, 14] = 1;
        tiles[15, 11] = 6;
        tiles[15, 12] = 6;
        tiles[15, 13] = 6;
        tiles[15, 14] = 6;
        tiles[16, 11] = 6;
        tiles[16, 12] = 6;
        tiles[16, 13] = 6;
        tiles[16, 14] = 6;
        tiles[17, 11] = 1;
        tiles[17, 12] = 1;
        tiles[17, 13] = 1;
        tiles[17, 14] = 1;
        tiles[18, 11] = 1;
        tiles[18, 12] = 1;
        tiles[18, 13] = 1;
        tiles[18, 14] = 1;
        tiles[19, 11] = 1;
        tiles[19, 12] = 1;
        tiles[19, 13] = 1;
        tiles[19, 14] = 6;

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
