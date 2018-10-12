using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour {

    public Text HighScoreText;

	// Use this for initialization
	void Start () {
        HighScoreText.text = "Highscore: " + PlayerPrefs.GetInt("score") + "m";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
