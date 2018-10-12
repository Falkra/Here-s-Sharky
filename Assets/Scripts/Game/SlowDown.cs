using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public float movementspeed = -0.05f;
    public float timer = 0f;

    public GameObject ThisObject;

    //public AudioSource shrek;

    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementspeed, 0, 0);

        if(transform.position.x <= -50)
        {
            //shrek.Stop();
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}

