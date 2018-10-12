using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlowdown : MonoBehaviour
{
    AudioSource Airhorn;

    private Vector3 pos3 = new Vector3(0, 0);

    private int hitPoints;
    private bool isHit1 = false;
    private bool isHit2 = false;
    private bool isHit3 = false;


    void Start()
    {
        Airhorn = GetComponent<AudioSource>();
        transform.position = pos3;
        hitPoints = 3;
    }
    


    void Update()
    {
       

    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle")
        {
            Airhorn.Play(0);
        }

        Destroy(other);
        if (other.tag == "Obstacle" && isHit2 && isHit1)
        {
            if (!isHit3)
            {
                isHit3 = true;
                Death();
            }
        }

        else if (other.tag == "Obstacle" && isHit1)
        {
            if (!isHit2)
            {
                isHit2 = true;
                HPLost2();
            }
        }

        else if (other.tag == "Obstacle" && !isHit1)
        {
            if (!isHit1)
            {
                isHit1 = true;
                HPLost1();
            }
        }


    }
    void HPLost1()
    {
        hitPoints = 2;
        this.transform.SetPositionAndRotation(new Vector3(-1.18f, transform.position.y, transform.position.z), transform.rotation);
    }

    void HPLost2()
    {
        hitPoints = 1;
        this.transform.SetPositionAndRotation(new Vector3(-3.17f, transform.position.y, transform.position.z), transform.rotation);
    }

    void Death()
    {
        hitPoints = 0;
        this.transform.SetPositionAndRotation(new Vector3(-7.46f, transform.position.y, transform.position.z), transform.rotation);
        StartCoroutine(WaitABit());


    }

    void TrueOrFalse()
    {
        if (isHit1)
        {
            HPLost1();
        }

        if (isHit2)
        {
            HPLost2();
        }

        if (isHit3)
        {
            Death();

            Destroy(this);
        }
    }


    IEnumerator WaitABit()
    {
        yield return new WaitForSeconds(2.0f);
    }
}

