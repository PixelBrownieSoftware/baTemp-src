using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level4 : GameManager {

    // Use this for initialization
    new void Start()
    {
        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 3;

        advice = "As you see the blue blocks turn the ball cold. Try switching to hot mode using A and S buttons. And presss the Z block to place a block.  Rest assured, you'll figure it out.";

        time_limit = 18f;

        tiles = new int[xSize, ySize];

        base.Start();
        
        tiles[7, 3] = 6;
        tiles[7, 4] = 6;
        tiles[7, 5] = 6;
        tiles[7, 6] = 6;
        tiles[7, 7] = 6;
        tiles[7, 8] = 6;
        tiles[7, 9] = 6;
        tiles[7, 10] = 6;
        tiles[7, 11] = 6;


        tiles[8, 3] = 6;
        tiles[8, 4] = 6;
        tiles[8, 5] = 6;
        tiles[8, 6] = 6;
        tiles[8, 7] = 6;
        tiles[8, 8] = 6;
        tiles[8, 9] = 6;
        tiles[8, 10] = 6;
        tiles[8, 11] = 6;

        tiles[9, 3] = 1;
        tiles[9, 4] = 1;
        tiles[9, 5] = 1;
        tiles[9, 6] = 1;
        tiles[9, 7] = 1;

        tiles[10, 3] = 1;
        tiles[10, 4] = 1;
        tiles[10, 5] = 1;
        tiles[10, 6] = 1;
        tiles[10, 7] = 1;
        tiles[11, 3] = 1;
        tiles[11, 4] = 1;
        tiles[11, 5] = 1;
        tiles[11, 6] = 1;
        tiles[11, 7] = 1;
        

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
