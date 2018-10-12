using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Joran de Lang

public class MoveBack : MonoBehaviour {
    //move
    public float moveSpeed = 0.08f;
    public GameObject thisObject;

    //spawn backdrop
    public GameObject Back1;
    public GameObject Back2;
    public GameObject BackEasteregg1;

    public GameObject Shark;

    private bool needNewBackdrop = true;


    // Use this for initialization
    void Start () {
        if (!Shark.GetComponent<NomSound>().GameActive)
        {
            needNewBackdrop = false;
        }
        else
        {
            needNewBackdrop = true;
        }

    }
	
	// Moving, destroying and spawning new backdrops
	void Update () {
        Move();
        
    }


    //creating a new backdrop
    private void SpawnNewBackdrop()
    {

        int random = Random.Range(1, 4);

        if (random <= 2)
        {
            Instantiate(Back1, new Vector3(26F, 0, 0), Quaternion.identity);
        }
        else if (random >= 3)
        {
            random = Random.Range(1, 50);
            if (random == 25)
            {
                Instantiate(BackEasteregg1, new Vector3(26F, 0, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(Back2, new Vector3(26F, 0, 0), Quaternion.identity);
            }
        }
        else
        {
            Debug.Log("Backdrop oof");
        }

    }

    private void Move()
    {
        transform.Translate(-moveSpeed, 0, 0);

        if (transform.position.x <= -35)
        {
            Destroy(thisObject);
        }

        if (transform.position.x <= -1.7 && needNewBackdrop)
        {
            needNewBackdrop = false;
            SpawnNewBackdrop();
        }
    }

}
