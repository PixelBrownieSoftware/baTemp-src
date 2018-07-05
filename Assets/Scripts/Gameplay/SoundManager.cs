using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    public AudioSource PlacingIceBlock;
    public AudioSource PlacingFireBlock;   //Drag a reference to the audio source which will play the sound effects.
    public AudioSource Bound;
    public AudioSource RemoveBlock;

    public AudioSource Music;
    public AudioSource City;

    void Start() {

        Music.Play();


    }

    void Update()
{

}
}

    
