using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerJu87 : MonoBehaviour
{
    public GameObject[] planePrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = -50;
    private float startDelay = 30.0f;
    private float spawnInterwal = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPlane", startDelay, spawnInterwal);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomPlane()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int planeIndex = Random.Range(0, planePrefabs.Length);
        Instantiate(planePrefabs[planeIndex], spawnPos, planePrefabs[planeIndex].transform.rotation);
    }
}