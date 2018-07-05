using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {

    protected LevelManager lmanager;
    public Animator wellDoneScrnAnim;
    

    void Start () {
        lmanager = GameObject.Find("Levels").GetComponent<LevelManager>();
        wellDoneScrnAnim = lmanager.WelldoneScrn.gameObject.GetComponent<Animator>();
    }
	
    public void welldoneAnimationDone(){
        wellDoneScrnAnim.SetBool("hidden", true);
    }
}
