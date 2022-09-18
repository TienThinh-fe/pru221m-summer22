using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherSpawner : MonoBehaviour
{
    public GameObject ChainsawLauncher;
    public GameObject PirateLauncher;
    public GameObject ZombieLauncher;

    public float spawnTimer;
    public int spawnIndex;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 3;
        spawnIndex = 1;
        SpawnLauncher(spawnIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0 && spawnIndex <= 3)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            spawnTimer = 3;
            spawnIndex++;
            SpawnLauncher(spawnIndex);
        }
    }

    void SpawnLauncher(int index)
    {
        switch (index)
        {
            case 1:
                Instantiate(ChainsawLauncher, new Vector3(-5, 0, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(PirateLauncher, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(ZombieLauncher, new Vector3(5, 0, 0), Quaternion.identity);
                break;
        }
    }
}
