using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

    protected LevelManager lmanager;
    public Animator gamOverScrnAnim;

    
    void Start () {
        lmanager = GameObject.Find("Levels").GetComponent<LevelManager>();
        gamOverScrnAnim = lmanager.gamOverScrn.gameObject.GetComponent<Animator>();
    }

    public void gameoverAnimationDone(){
        gamOverScrnAnim.SetBool("hidden", true);
    }
}
