using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DialogueText : MonoBehaviour {

    public string[] dialouge;
    public Text textDisp;
    public int currentLine = 0;
    private float textDelay = 0.05f;
    public string textToDisplay;
    public float[] delay;

    private bool isTyping = false;
    private SoundManager sfx;

    void Start() {
        sfx = GameObject.Find("City sound").GetComponent<SoundManager>();

    }

    public IEnumerator textPresent(string lettertxt) {
        int letter = 0;
        textDisp.text = "";
        isTyping = true;

        while (isTyping && letter < lettertxt.Length) {
            textDisp.text += lettertxt[letter];
            letter++;
            yield return new WaitForSeconds(textDelay);
        }
        textDisp.text = lettertxt;
        isTyping = false;
        yield return new WaitForSeconds(delay[currentLine]);
        textDisp.text = "";
    }

    void SFX() {
        sfx.City.Play();
    }

    void introduction() {

        textToDisplay = dialouge[currentLine];
        StartCoroutine(textPresent(textToDisplay));
    }

    public void incrementLine() {
        textDisp.color = new Color(0f,0f,0f,1f);
        currentLine++;
        textToDisplay = dialouge[currentLine];
        StartCoroutine(textPresent(textToDisplay));
    }

    public void toGame() {

        SceneManager.LoadScene("Main menu");

    }

}
