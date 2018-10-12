using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Joran de Lang

public class AddDistance : MonoBehaviour {

    public Text Distance;
    public Text DistanceEnd;
    public int DistanceScore = 0;

    public float ResetDisTimer = 10;
    private float DisTimer = 0;


	// Timer Setup
	void Start () {
        DisTimer = ResetDisTimer;
        DistanceScore = 0;
        Distance.text = "Distance: " + 0 + "m";
    }
	
	// Adding score
	void Update () {
        if (DisTimer <= 0)
        {
            DistanceScore = DistanceScore + 1;
            Distance.text = "Distance: " + DistanceScore + "m";
            DistanceEnd.text = "Distance: " + DistanceScore + "m";
            DisTimer = DisTimer + ResetDisTimer;
        }
        else
        {
            DisTimer = DisTimer - 1;
        }
        //print(DisTimer);
        
    }

    
}
