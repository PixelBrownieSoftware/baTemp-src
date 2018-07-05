using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelTest : GameManager {

	// Use this for initialization
	new void Start () {

        tileObjects = GameObject.FindGameObjectsWithTag("Blocks");

        levelId = 4343242;

        time_limit = 99999999f;

        tiles = new int[xSize, ySize];

        base.Start();

        advice = "???";

        //   balls[0].GetComponent<BallScript>().initY = 3;
        //  balls[0].GetComponent<BallScript>().initX = 7;

        

        if (lmanager.level == levelId) { lmanager.time = time_limit; levelGen(); }

    }
	

	// Update is called once per frame
	new void Update () {
        base.Update();
	}
}
