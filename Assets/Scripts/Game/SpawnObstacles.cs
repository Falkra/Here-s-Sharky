using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Joran de Lang

public class SpawnObstacles : MonoBehaviour {

    public GameObject Obstacle1;
    public GameObject Shark;
    public GameObject ObjectEasteregg1;

    //obstacle positions to prevent impossible runs
    private float ObstacleYpos1 = -6f;
    private float ObstacleYpos2 = -4f;
    private float ObstacleYpos3 = -2f;
    private float ObstacleYpos4 = 0f;
    private float ObstacleYpos5 = 2f;
    private float ObstacleYpos6 = 4f;

    public float resetObstacleTimer = 15;
    private float ObstacleTimer = 0;

	// Use this for initialization
	void Start () {

	}
	
	//Spawn timer for obstacles
	void Update () {
        ObstacleTimer--;
        if(ObstacleTimer <= 0)
        {
            ObstacleTimer = resetObstacleTimer;
            SpawnObstacle();
        }
	}
    //spawns the obstacles
    private void SpawnObstacle()
    {
        if (Shark.GetComponent<NomSound>().GameActive)
        {
            int random = Random.Range(0, 9);

            if (random == 1)
            {
                Instantiate(Obstacle1, new Vector3(30F, ObstacleYpos1, 0), Quaternion.identity);

            }
            else if (random == 2)
            {
                Instantiate(Obstacle1, new Vector3(30F, ObstacleYpos2, 0), Quaternion.identity);

            }
            else if (random == 3)
            {
                Instantiate(Obstacle1, new Vector3(30F, ObstacleYpos3, 0), Quaternion.identity);

            }
            else if (random == 4)
            {
                random = Random.Range(0, 15);
                if (random == 10)
                {
                    Instantiate(ObjectEasteregg1, new Vector3(30F, ObstacleYpos4, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(Obstacle1, new Vector3(30F, ObstacleYpos4, 0), Quaternion.identity);
                }

            }
            else if (random == 5)
            {
                Instantiate(Obstacle1, new Vector3(30F, ObstacleYpos5, 0), Quaternion.identity);

            }
            else if (random == 6)
            {
                Instantiate(Obstacle1, new Vector3(30F, ObstacleYpos6, 0), Quaternion.identity);

            }
            else if (random <= 7)
            {

            }
        }

    }
}
