using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level9 : GameManager {

    new void Start()
    {

        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 8;

        advice = "Null";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 18f;

        //bottom body
        tiles[6 , 3] = 6;
        tiles[6, 4] = 6;
        tiles[6, 5] = 6;
        tiles[6, 6] = 6;
        tiles[6, 7] = 4;

        tiles[7, 3] = 6;
        tiles[7, 4] = 6;
        tiles[7, 5] = 6;
        tiles[7, 6] = 6;
        tiles[7, 7] = 6;

        tiles[8, 3] = 6;
        tiles[8, 4] = 6;
        tiles[8, 5] = 6;
        tiles[8, 6] = 6;
        tiles[8, 7] = 6;

        tiles[9, 3] = 6;
        tiles[9, 4] = 6;
        tiles[9, 5] = 6;
        tiles[9, 6] = 6;
        tiles[9, 7] = 6;

        tiles[10,3] = 6;
        tiles[10,4] = 6;
        tiles[10,5] = 6;
        tiles[10,6] = 6;
        tiles[10,7] = 6;

        tiles[11,3] = 6;
        tiles[11,4] = 6;
        tiles[11,5] = 6;
        tiles[11,6] = 6;
        tiles[11,7] = 6;

        tiles[12,3] = 6;
        tiles[12,4] = 6;
        tiles[12,5] = 6;
        tiles[12,6] = 6;
        tiles[12,7] = 6;
        tiles[12,7] = 6;

        tiles[13, 3] = 6;
        tiles[13, 4] = 6;
        tiles[13, 5] = 6;
        tiles[13, 6] = 6;
        tiles[13, 7] = 6;
        tiles[13, 7] = 6;

        tiles[14, 3] = 6;
        tiles[14, 4] = 6;
        tiles[14, 5] = 6;
        tiles[14, 6] = 6;
        tiles[14, 7] = 6;
        tiles[14, 7] = 6;

        tiles[15, 3] = 6;
        tiles[15, 4] = 6;
        tiles[15, 5] = 6;
        tiles[15, 6] = 6;
        tiles[15, 7] = 3;

        tiles[16, 3] = 6;
        tiles[16, 4] = 6;
        tiles[16, 5] = 6;
        tiles[16, 6] = 3;
        tiles[16, 7] = 3;

        tiles[17, 3] = 6;
        tiles[17, 4] = 6;
        tiles[17, 5] = 6;
        tiles[17, 6] = 3;
        tiles[17, 7] = 3;

        //bottom segment 1

        tiles[18, 6] = 6;
        tiles[18, 7] = 6;

        tiles[19, 6] = 6;
        tiles[19, 7] = 6;

        tiles[20, 6] = 6;
        tiles[20, 7] = 6;

        //bottom segment 2
        tiles[10, 8] = 6;
        tiles[10, 9] = 6;

        tiles[11, 8] = 6;
        tiles[11, 9] = 6;

        //middle part
        tiles[19, 8] = 6;
        tiles[19, 9] = 6;
        tiles[19, 10] = 6;
        tiles[19, 11] = 6;
        tiles[19, 12] = 6;

        tiles[20, 8] = 6;
        tiles[20, 9] = 6;
        tiles[20, 10] = 6;
        tiles[20, 11] = 6;
        tiles[20, 12] = 6;

        //up
        tiles[5, 10] = 6;
        tiles[5, 11] = 6;
        tiles[5, 12] = 6;
        tiles[5, 13] = 6;
        tiles[5, 14] = 6;


        tiles[06, 10] = 6;
        tiles[06, 11] = 6;
        tiles[06, 12] = 6;
        tiles[06, 13] = 6;
        tiles[06, 14] = 6;


        tiles[07, 10] = 6;
        tiles[07, 11] = 6;
        tiles[07, 12] = 6;
        tiles[07, 13] = 6;
        tiles[07, 14] = 6;

        tiles[08, 10] = 6;
        tiles[08, 11] = 6;
        tiles[08, 12] = 6;
        tiles[08, 13] = 6;
        tiles[08, 14] = 6;

        tiles[09, 10] = 4;
        tiles[09, 11] = 6;
        tiles[09, 12] = 6;
        tiles[09, 13] = 6;
        tiles[09, 14] = 6;

        tiles[10, 8] = 5;
        tiles[10, 9] = 4;
        tiles[10, 10] = 4;
        tiles[10, 11] = 6;
        tiles[10, 12] = 6;
        tiles[10, 13] = 6;
        tiles[10, 14] = 6;

        tiles[11, 8] = 5;
        tiles[11, 9] = 4;
        tiles[11, 10] = 4;
        tiles[11, 11] = 6;
        tiles[11, 12] = 6;
        tiles[11, 13] = 6;
        tiles[11, 14] = 6;

        tiles[12, 10] = 4;
        tiles[12, 11] = 6;
        tiles[12, 12] = 6;
        tiles[12, 13] = 6;
        tiles[12, 14] = 6;

        //smaller part
        tiles[13, 12] = 6;
        tiles[13, 13] = 6;
        tiles[13, 14] = 6;

        tiles[14, 12] = 6;
        tiles[14, 13] = 6;
        tiles[14, 14] = 6;

        tiles[15, 12] = 5;
        tiles[15, 13] = 6;
        tiles[15, 14] = 6;

        tiles[16, 13] = 6;
        tiles[16, 14] = 6;

        tiles[17, 13] = 3;
        tiles[17, 14] = 3;

        tiles[18, 13] = 4;
        tiles[18, 14] = 4;

        tiles[19, 14] = 4;
        tiles[19, 13] = 4;
        tiles[19, 12] = 4;
        tiles[19, 11] = 4;
        tiles[19, 10] = 4;
        tiles[19, 9] = 4;
        tiles[19, 8] = 4;
        tiles[19, 7] = 4;
        tiles[19, 6] = 4;

        tiles[20, 14] = 4;
        tiles[20, 13] = 4;
        tiles[20, 12] = 4;
        tiles[20, 11] = 4;
        tiles[20, 10] = 4;
        tiles[20, 9] = 4;
        tiles[20, 8] = 4;
        tiles[20, 7] = 4;
        tiles[20, 6] = 4;



        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    new void Update()
    {
        base.Update();
    }
}
