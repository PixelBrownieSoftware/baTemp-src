using UnityEngine;
using System.Collections;
[System.Serializable]
public class TileCells {

    public SpriteRenderer blockColour;

    public string name;
    public GameObject tileVisual;
    // this is for the gameManager to check which type
    public enum temperature { NEUTRAL, HOT, COLD }
    public temperature temp;

}
