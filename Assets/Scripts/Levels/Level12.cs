using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Level12 : GameManager {

    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 11;

        advice = "The 'lock' is probabaly the ice, maybe what is on the end of the key may help..";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 25f;

        //circle
        tiles[9, 5] = 5;
        tiles[8, 5] = 5;
        tiles[7, 5] = 5;
        tiles[6, 5] = 5;
        tiles[5, 5] = 5;

        tiles[4, 6] = 1;
        tiles[5, 6] = 6;
        tiles[6, 6] = 6;
        tiles[7, 6] = 6;
        tiles[8, 6] = 6;
        tiles[9, 6] = 6;
        tiles[10, 6] = 1;

        tiles[3, 7] = 5;
        tiles[3, 8] = 5;
        tiles[3, 9] = 5;
        tiles[3,10] = 5;

        tiles[4, 7] = 1;
        tiles[4, 8] = 6;
        tiles[4, 9] = 6;
        tiles[4, 10] = 1;
        tiles[4, 11] = 5;

        tiles[5, 7] = 5;
        tiles[5, 8] = 6;
        tiles[5, 9] = 6;
        tiles[5, 10] = 6;
        tiles[5, 11] = 6;
        tiles[5, 12] = 5;

        tiles[6, 7] = 6;
        tiles[6, 8] = 6;
        tiles[6, 9] = 6;
        tiles[6, 10] = 6;
        tiles[6, 11] = 6;
        tiles[6, 12] = 5;


        tiles[7, 7] = 6;
        tiles[7, 8] = 6;
        tiles[7, 9] = 6;
        tiles[7, 10] = 6;
        tiles[7, 11] = 6;
        tiles[7, 12] = 5;

        tiles[8, 7] = 5;
        tiles[8, 8] = 6;
        tiles[8, 9] = 6;
        tiles[8, 10] = 6;
        tiles[8, 11] = 6;
        tiles[8, 12] = 5;

        tiles[9, 7] = 6;
        tiles[9, 8] = 6;
        tiles[9, 9] = 6;
        tiles[9, 10] = 6;
        tiles[9, 11] = 6;
        tiles[9, 12] = 5;

        tiles[10, 7] = 6;
        tiles[10, 8] = 6;
        tiles[10, 9] = 6;
        tiles[10, 10] = 6;
        tiles[10, 11] =5;

        tiles[11, 7] = 6;
        tiles[11, 8] = 6;
        tiles[11, 9] = 5;
        tiles[11, 10] = 5;

        //the easy bit - line
        tiles[12,7]= 6;
        tiles[13, 7] = 2;
        tiles[14, 7] = 2;
        tiles[15, 7] = 2;
        tiles[16, 7] = 2;
        tiles[17, 7] = 6;
        tiles[18, 7] = 2;
        tiles[19, 7] = 2;
        tiles[20, 7] = 2;

        tiles[12, 8] = 2;
        tiles[13, 8] = 2;
        tiles[14, 8] = 2;
        tiles[15, 8] = 2;
        tiles[16, 8] = 2; tiles[16, 9] = 4; tiles[16, 10] = 4; tiles[16, 11] = 4;
        tiles[17, 8] = 2;
        tiles[18, 8] = 2; tiles[18,9] = 5; tiles[18, 10] = 5; tiles[18, 11] = 5;
        tiles[19, 8] = 2;
        tiles[20, 8] = 6; tiles[20, 9] = 3; tiles[20, 10]=3; tiles[20, 11] = 3;



        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    new void Update()
    {
        base.Update();
    }
}
