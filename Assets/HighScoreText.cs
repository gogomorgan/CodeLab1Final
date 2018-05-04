using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreText : MonoBehaviour {

    public TextMesh highscoreText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        highscoreText.text = "High Score: " + GameManager.instance.highScore;

    }
}
