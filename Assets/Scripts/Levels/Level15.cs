using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level15 : GameManager {

    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 14;

        advice = "Here is the Excalibur of fire! Only a true chosen warrior can cool it down!";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 35f;

        tiles[7, 5] = 4;
        tiles[7, 6] = 4;
        tiles[7, 8] = 3;
        tiles[7, 9] = 2;
        tiles[7, 10] = 3;
        tiles[7, 11] = 2;

        tiles[8, 4] = 4;
        tiles[8, 5] = 3;
        tiles[8, 6] = 4;
        tiles[8, 7] = 2;
        tiles[8, 8] = 6;
        tiles[8, 09] = 6;
        tiles[8, 10] = 2;

        tiles[9, 4] = 4;
        tiles[9, 5] = 4;
        tiles[9, 6] = 4;
        tiles[9, 7] = 6;
        tiles[9, 8] = 6;
        tiles[9, 9] = 4;

        tiles[10, 5] = 4;
        tiles[10, 6] = 6;
        tiles[10, 7] = 4;
        tiles[10, 8] = 4;
        tiles[10, 9] = 5;
        tiles[10, 10] = 6;

        tiles[11, 4] = 4;
        tiles[11, 5] = 2;
        tiles[11, 6] = 6;
        tiles[11, 7] = 6;
        tiles[11, 8] = 5;
        tiles[11, 8] = 6;
        tiles[11, 10] = 6;
        tiles[11, 11] = 6;

        tiles[12, 3] = 3;
        tiles[12, 4] = 2;
        tiles[12, 5] = 3;
        tiles[12, 6] = 4;
        tiles[12, 7] = 5;
        tiles[12, 8] = 5;
        tiles[12, 9] = 5;
        tiles[12, 10] = 5;
        tiles[12, 11] = 6;

        tiles[13, 4] = 3;
        tiles[13, 5] = 4;
        tiles[13, 12] = 6;
        tiles[13, 12] = 5;

        tiles[14, 4] = 4;
        tiles[14, 3] = 4;
        tiles[14, 14] = 6;
        tiles[14, 13] = 6;
        tiles[14, 12] = 4;

        tiles[17, 4] = 5;
        tiles[17, 15] = 5;
        tiles[16, 14] = 1;
        tiles[17, 11] = 1;
        tiles[16, 15] = 5;
        tiles[16, 10] = 1;
        tiles[15, 15] = 5;
        tiles[15, 08] = 5;
        tiles[15, 09] = 5;
        tiles[18, 15] = 5;
        tiles[14, 08] = 1;
        tiles[13, 07] = 5;
        tiles[12, 07] = 5;

        tiles[6, 09] = 2;
        tiles[6, 10] = 2;
        tiles[6, 11] = 2;



        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    new void Update()
    {
        base.Update();
    }
}
