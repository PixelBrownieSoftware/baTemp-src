using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level8 : GameManager {
    
    new void Start()
    {

        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 7;

        advice = "Oh! Those dark blue frost blocks you can't destory either!";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 20f;

        tiles[5,8] = 6;
        tiles[5, 9] = 5;
        tiles[5, 10] = 6;
        tiles[5, 11] = 6;
        tiles[5, 12] = 5;
        tiles[5, 13] = 6;
        tiles[5, 14] = 5;

        tiles[6, 8] = 6;
        tiles[6, 9] = 6;
        tiles[6, 10] = 6;
        tiles[6, 11] = 6;
        tiles[6, 12] = 6;
        tiles[6, 13] = 6;
        tiles[6, 14] = 5;

        tiles[7, 8] = 5;
        tiles[7, 9] = 6;
        tiles[7, 10] = 6;
        tiles[7, 11] = 6;
        tiles[7, 12] = 6;
        tiles[7, 13] = 6;
        tiles[7, 14] = 6;

        tiles[8, 8] = 6;
        tiles[8, 9] = 6;
        tiles[8, 10] = 6;
        tiles[8, 11] = 6;
        tiles[8, 12] = 6;
        tiles[8, 13] = 6;
        tiles[8, 14] = 6;

        tiles[9, 8] = 5;
        tiles[9, 9] = 6;
        tiles[9, 10] = 6;
        tiles[9, 11] = 6;
        tiles[9, 12] = 6;
        tiles[9, 13] = 6;
        tiles[9, 14] = 5;

        tiles[10, 8] = 5;
        tiles[10, 9] = 6;
        tiles[10, 10] = 6;
        tiles[10, 11] = 6;
        tiles[10, 12] = 6;
        tiles[10, 13] = 6;
        tiles[10, 14] = 5;

        //corridor
        tiles[11, 9] = 6;
        tiles[11, 10] = 6;
        tiles[11, 11] = 6;
        tiles[11, 12] = 4;

        tiles[12, 9] = 5;
        tiles[11, 10] = 6;
        tiles[12, 11] = 6;
        tiles[12, 12] = 6;

        tiles[13, 9] = 5;
        tiles[13, 10] = 6;
        tiles[13, 11] = 6;
        tiles[13, 12] = 4;

        tiles[14, 9] = 5;
        tiles[14, 10] = 6;
        tiles[14, 11] = 6;
        tiles[14, 12] = 5;

        tiles[15, 8] = 4;
        tiles[15, 9] = 6;
        tiles[15, 10] = 2;
        tiles[15, 11] = 6;
        tiles[15, 12] = 6;
        tiles[15, 13] = 6;
        tiles[15, 14] = 6;

        tiles[16, 8] = 6;
        tiles[16, 9] = 6;
        tiles[16, 10] = 6;
        tiles[16, 11] = 6;
        tiles[16, 12] = 6;
        tiles[16, 13] = 6;
        tiles[16, 14] = 4;

        tiles[17, 8] = 5;
        tiles[17, 9] = 6;
        tiles[17, 10] = 6;
        tiles[17, 11] = 6;
        tiles[17, 12] = 6;
        tiles[17, 13] = 6;
        tiles[17, 14] = 4;

        tiles[18, 8] = 5;
        tiles[18, 9] = 6;
        tiles[18, 10] = 6;
        tiles[18, 11] = 6;
        tiles[18, 12] = 6;
        tiles[18, 13] = 6;
        tiles[18, 14] = 6;

        tiles[19, 8] = 6;
        tiles[19, 9] = 6;
        tiles[19, 10] = 6;
        tiles[19, 11] = 6;
        tiles[19, 12] = 6;
        tiles[19, 13] = 6;
        tiles[19, 14] = 4;

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }
    
    new void Update()
    {
        base.Update();
    }
}
