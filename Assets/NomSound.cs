using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomSound : MonoBehaviour {

    AudioSource Nomnom;

    public bool GameActive = true;

    // Use this for initialization
    void Start () {
        Nomnom = GetComponent<AudioSource>();
        GameActive = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Nomnom.Play(0);
            GameActive = false;
        }
    }
}
