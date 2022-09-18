using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallSpawner : MonoBehaviour
{
    public GameObject whiteBall;
    public GameObject greenBall;
    public GameObject redBall;

    List<GameObject> platforms = new List<GameObject>();

    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 3;
        spawnRandomBall();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            spawnTimer = 3;
            DestroyAllPlatforms();
            spawnRandomBall();
        }
    }

    int getRandomNumber()
    {
        System.Random rnd = new System.Random();
        return rnd.Next(1, 4);
    }

    void spawnRandomBall()
    {
        int randomBallIndex = getRandomNumber();
        switch (randomBallIndex)
        {
            case 1:
                //Instantiate(whiteBall, new Vector3(0, 0, 0), Quaternion.identity);
                platforms.Add(Instantiate(whiteBall, new Vector3(0, 0, 0), Quaternion.identity));
                break;
            case 2:
                //Instantiate(greenBall, new Vector3(0, 0, 0), Quaternion.identity);
                platforms.Add(Instantiate(greenBall, new Vector3(0, 0, 0), Quaternion.identity));
                break;
            case 3:
                //Instantiate(redBall, new Vector3(0, 0, 0), Quaternion.identity);
                platforms.Add(Instantiate(redBall, new Vector3(0, 0, 0), Quaternion.identity));
                break;
        }
    }

    void DestroyAllPlatforms()
    {
        foreach (GameObject platform in platforms)
        {
            Destroy(platform);
        }
        platforms.Clear();
    }
}
