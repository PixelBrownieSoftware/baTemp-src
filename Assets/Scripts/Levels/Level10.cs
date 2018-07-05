using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level10 : GameManager {

    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 9;

        advice = "Try to add hot and cold blocks to the area to help neutralise temperature";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 30f;

        //left arm
        tiles[2, 8] = 4;
        tiles[2, 9] = 6;
        tiles[2, 10] = 6;
        tiles[2, 11] = 6;
        tiles[2, 12] = 6;
        tiles[2, 13] = 4;

        tiles[3, 8] = 6;
        tiles[3, 9] = 6;
        tiles[3, 10] = 6;
        tiles[3, 11] = 2;
        tiles[3, 12] = 6;
        tiles[3, 13] = 6;

        tiles[4, 8] = 6;
        tiles[4, 9] = 6;
        tiles[4, 10] = 6;
        tiles[4, 11] = 6;
        tiles[4, 12] = 6;
        tiles[4, 13] = 6;

        tiles[5, 8] = 4;
        tiles[5, 9] = 6;
        tiles[5, 10] = 6;
        tiles[5, 11] = 6;
        tiles[5, 12] = 6;
        tiles[5, 13] = 6;

        //armsegment
        tiles[6, 9] = 6;
        tiles[6, 10] = 6;
        tiles[6, 11] = 6;

        tiles[7, 9] = 4;
        tiles[7, 10] = 4;
        tiles[7, 11] = 4;

        //body
        tiles[7, 9] = 4;
        tiles[7, 10] = 4;
        tiles[7, 11] = 4;

        tiles[8, 5] = 6;
        tiles[8, 6] = 6;
        tiles[8, 7] = 6;
        tiles[8, 8] = 6;
        tiles[8, 9] = 6;
        tiles[8, 10] = 4;
        tiles[8, 11] = 4;

        tiles[09, 5] = 6;
        tiles[09, 6] = 6;
        tiles[09, 7] = 6;
        tiles[09, 8] = 6;
        tiles[09, 9] = 4;
        tiles[09, 10] = 6;
        tiles[09, 11] = 4;

        tiles[10, 5] = 6;
        tiles[10, 6] = 6;
        tiles[10, 7] = 4;
        tiles[10, 8] = 4;
        tiles[10, 9] = 4;
        tiles[10, 10] = 6;
        tiles[10, 11] = 4;

        tiles[11, 5] = 6;
        tiles[11, 6] = 6;
        tiles[11, 7] = 6;
        tiles[11, 8] = 6;
        tiles[11, 9] = 4;
        tiles[11, 10] = 6;
        tiles[11, 11] = 4;

        tiles[12, 5] = 6;
        tiles[12, 6] = 6;
        tiles[12, 7] = 6;
        tiles[12, 8] = 6;
        tiles[12, 9] = 6;
        tiles[12, 10] = 4;

        tiles[13, 5] = 6;
        tiles[13, 6] = 6;
        tiles[13, 7] = 6;
        tiles[13, 8] = 6;
        tiles[13, 9] = 6;
        tiles[13, 10] = 6;
        tiles[13, 11] = 4;

        tiles[14, 5] = 6;
        tiles[14, 6] = 6;
        tiles[14, 7] = 6;
        tiles[14, 8] = 6;
        tiles[14, 9] = 6;
        tiles[14, 10] = 4;
        tiles[14, 11] = 4;

        tiles[15, 5] = 6;
        tiles[15, 6] = 6;
        tiles[15, 7] = 6;
        tiles[15, 8] = 6;
        tiles[15, 9] = 6;
        tiles[15, 10] = 6;
        tiles[15, 11] = 4;

        //head
        tiles[8, 12] = 5;
        tiles[8, 13] = 6;
        tiles[8, 14] = 6;

        tiles[09, 12] = 6;
        tiles[09, 13] = 6;
        tiles[09, 14] = 6;

        tiles[10, 12] = 6;
        tiles[10, 13] = 6;
        tiles[10, 14] = 6;

        tiles[11, 12] = 6;
        tiles[11, 13] = 6;
        tiles[11, 14] = 6;

        tiles[12, 12] = 6;
        tiles[12, 13] = 6;
        tiles[12, 14] = 6;

        tiles[13, 12] = 6;
        tiles[13, 13] = 6;
        tiles[13, 14] = 6;

        tiles[14, 12] = 6;
        tiles[14, 13] = 6;
        tiles[14, 14] = 6;

        tiles[15, 12] = 5;
        tiles[15, 13] = 6;
        tiles[15, 14] = 6;

        //ears
        tiles[15, 15] = 5;
        tiles[8, 15] = 5;

        //armsegment
        tiles[16, 9] = 5;
        tiles[16, 10] = 5;
        tiles[16, 11] = 5;

        tiles[17, 9] = 6;
        tiles[17, 10] = 6;
        tiles[17, 11] = 6;

        //right arm
        tiles[18, 8] = 5;
        tiles[18, 9] = 6;
        tiles[18, 10] = 6;
        tiles[18, 11] = 6;
        tiles[18, 12] = 6;
        tiles[18, 13] = 5;

        tiles[19, 8] = 6;
        tiles[19, 9] = 6;
        tiles[19, 10] = 6;
        tiles[19, 11] = 2;
        tiles[19, 12] = 6;
        tiles[19, 13] = 6;

        tiles[20, 8] = 6;
        tiles[20, 9] = 6;
        tiles[20, 10] = 6;
        tiles[20, 11] = 6;
        tiles[20, 12] = 6;
        tiles[20, 13] = 6;

        tiles[21, 8] = 5;
        tiles[21, 9] = 6;
        tiles[21, 10] = 6;
        tiles[21, 11] = 6;
        tiles[21, 12] = 6;
        tiles[21, 13] = 5;


        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    new void Update()
    {
        base.Update();
    }
}
