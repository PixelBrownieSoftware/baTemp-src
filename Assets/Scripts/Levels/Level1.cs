using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
Notes 25/07/2018:
This is how I made all the levels in this game.
I hard-coded them into the game and put them as a sepearate class; yes, I was that stupid.
I didn't really know how to make a level editor at the time let alone make a tile array thing.

Happy to say that if I remade this game now,
I would have been able to create a level editor which would enable much more levels than 15 to come out.
They'd be more polished too.
*/

public class Level1 : GameManager {
    
	
	new void Start ()
	{
        levelId = 0;

        advice = " The temperature seems to be over 10°C... It's probably the best idea to remove the red blocks with the X button.";

        tiles = new int[xSize, ySize];

        base.Start();

        time_limit = 10f;

        //ice blocks
        tiles[5, 6] = 1;
        tiles[5, 7] = 1;
        tiles[5, 8] = 1;
        tiles[5, 9] = 1;

        //empty space
        tiles[6, 6] = 3;
        tiles[6, 7] = 3;
        tiles[6, 8] = 3;
        tiles[6, 9] = 3;
        tiles[7, 6] = 3;
        tiles[7, 7] = 3;
        tiles[7, 8] = 3;
        tiles[7, 9] = 3;
        tiles[8, 6] = 3;
        tiles[8, 7] = 3;
        tiles[8, 8] = 3;
        tiles[8, 9] = 3;
        tiles[9, 6] = 3;
        tiles[9, 7] = 3;
        tiles[9, 8] = 3;
        tiles[9, 9] = 3;
        tiles[10, 6] = 6;
        tiles[10, 7] = 6;
        tiles[10, 8] = 6;
        tiles[10, 9] = 6;
        tiles[11, 6] = 6;
        tiles[11, 7] = 6;
        tiles[11, 8] = 6;
        tiles[11, 9] = 6;
        tiles[12, 6] = 6;
        tiles[12, 7] = 6;
        tiles[12, 8] = 6;
        tiles[12, 9] = 6;

        //hot blocks
        tiles[13, 6] = 2;
        tiles[13, 7] = 2;
        tiles[13, 8] = 2;
        tiles[13, 9] = 2;
        tiles[14, 6] = 2;
        tiles[14, 7] = 2;
        tiles[14, 8] = 2;
        tiles[14, 9] = 2;
        tiles[15, 6] = 2;
        tiles[15, 7] = 2;
        tiles[15, 8] = 2;
        tiles[15, 9] = 2;
        tiles[16, 6] = 2;
        tiles[16, 7] = 2;
        tiles[16, 8] = 2;
        tiles[16, 9] = 2;
        tiles[17, 6] = 2;
        tiles[17, 7] = 2;
        tiles[17, 8] = 2;
        tiles[17, 9] = 2;
        tiles[18, 6] = 2;
        tiles[18, 7] = 2;
        tiles[18, 8] = 2;
        tiles[18, 9] = 2;
        tiles[19, 6] = 2;
        tiles[19, 7] = 2;
        tiles[19, 8] = 2;
        tiles[19, 9] = 2;

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }
    }
	
	new void Update ()
	{
        	base.Update();
	}
}
