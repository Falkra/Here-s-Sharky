using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

    int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
            Save();
        else if (Input.GetKeyDown(KeyCode.L))
            Load();
	}

    public void Save()
    {
        score = 100;
        PlayerPrefs.SetInt("score", score);
        print("score saved");
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("score");
        print("Score loaded: " + score);
    }
}
