using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class LevelManager : MonoBehaviour {

    public GameManager gmanager;
    private Cursor cursor;

    private GameObject BG;
    private SpriteRenderer BG_sprite;
    public Sprite BG_sewer;
    public Sprite BG_city;

    public GameObject gamOverScrn;
    public GameOverScreen GameOverthing;
    public GameObject WelldoneScrn;
    public WinScreen Welldonething;


    public GameObject[] Levels;

    public int level;
    public enum levelLoader { idle ,increase_level, reload , load_level, game_over, game_over_animate, stage_complete, stage_complete_animate };
    public levelLoader levelLoad = levelLoader.idle;

    public Text timer;
    public Text temperatureTxt;
    public Text levelTxt;
    public Text levelDesc;

    

    public float time;
    // Use this for initialization

    void Start () {
        cursor = GameObject.Find("Cursor").GetComponent<Cursor>();
        level = 0;

        BG = GameObject.Find("BG");
        BG_sprite = BG.GetComponent<SpriteRenderer>();

        GameOverthing = GameObject.Find("game over").GetComponent<GameOverScreen>();
        Welldonething = GameObject.Find("well done").GetComponent<WinScreen>();
    }

    public void levelLoading() {
        switch (levelLoad)
        {
            case levelLoader.idle:
                cursor.canPlace = true;
                break;

            case levelLoader.stage_complete:
                time = 0f;
                gmanager.temperatureBlocks = 0;
                gmanager.temperatureBalls = 0;
                gmanager.deleteTiles();

                cursor.canPlace = false;
                //play animation here
                Welldonething.wellDoneScrnAnim.SetBool("hidden", false);
                levelLoad = levelLoader.stage_complete_animate;

                break;

            case levelLoader.stage_complete_animate:

                if (Welldonething.wellDoneScrnAnim.GetBool("hidden") == true) { if (level == 14) { SceneManager.LoadScene("EndScreen"); } else { levelLoad = levelLoader.increase_level; } }
                break;

            case levelLoader.game_over:
                time = 0f;
                gmanager.temperatureBlocks = 0;
                gmanager.temperatureBalls = 0;
                gmanager.deleteTiles();
                
                cursor.canPlace = false;
                GameOverthing.gamOverScrnAnim.SetBool("hidden", false);
                levelLoad = levelLoader.game_over_animate;
                break;

            case levelLoader.game_over_animate:

                if (GameOverthing.gamOverScrnAnim.GetBool("hidden") == true) { levelLoad = levelLoader.reload; }
                break;

            case levelLoader.increase_level:
                
                level++;
                PlayerPrefs.SetInt("currentLevel", level);
                levelLoad = levelLoader.load_level;

                break;

            case levelLoader.reload:
                gmanager.temperatrueTotal = 0;
                levelLoad = levelLoader.load_level;

                break;

            case levelLoader.load_level:
                if (time <= 0.4)
                {
                    gmanager.temperatrueTotal = 0;
                    gmanager.Start(); time = gmanager.time_limit;
                    gmanager.levelGen();
                }

                print("done!");
                levelLoad = levelLoader.idle;

                break;
        }

    }
    

    void Update() {

        //reload or load next level
        levelLoading();

        //goes thorugh levels
        for (int i = 0; i < Levels.Length; i++)
        {
            if (i == level)
            {
                Levels[i].gameObject.SetActive(true);
                gmanager = Levels[i].GetComponent<GameManager>();
                    continue;
            }
            else { Levels[i].gameObject.SetActive(false); }
        }

        //setting BG
        if (level <= 7) { BG_sprite.sprite = BG_sewer; BG_sprite.color = new Color(0.3f,0.5f,0.3f,0.5f); }
        if ( level > 7) { BG_sprite.sprite = BG_city; BG_sprite.color = new Color(0.3f, 0.2f, 0.3f, 0.9f); }


        //functions of level
        if (levelLoad == levelLoader.idle)
        {
            int tot = gmanager.temperatrueTotal;

            levelTxt.text = "Level: " + (level + 1);
            temperatureTxt.text = "Temperature: " + (tot) + "°C";
            timer.text = "Timer: " + Mathf.FloorToInt(time);
            if (gmanager.advice != "Null") { levelDesc.text = "Tip:" + gmanager.advice; } else levelDesc.text = "";
            

            if (tot >= 30 || tot <= -30)
            {
                
                levelLoad = levelLoader.game_over;
            }


            if (time >= 0.4)
            {
                time -= Time.deltaTime;
            }
            else
            {
                if (tot >= 10 || tot <= -10)
                {
                    gmanager.temperatrueTotal = 0;
                    levelLoad = levelLoader.game_over;
                }
                else if (tot <= 10 || tot >= -10)
                {
                    gmanager.temperatrueTotal = 0;
                    gmanager.deleteTiles();
                    levelLoad = levelLoader.stage_complete;


                }
            }
        } 
    }
}
