using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public int swimSpeedUp = 4;
    public int swimSpeedDown = -2;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetButton("swim") && transform.position.y <= 4.4)
        {
            transform.Translate(0, swimSpeedUp*Time.deltaTime, 0);
        }
        else if (transform.position.y >= -6.7) 
        {
            transform.Translate(0, swimSpeedDown*Time.deltaTime, 0);
        }
        
	}
}
