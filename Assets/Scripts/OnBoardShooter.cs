using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardShooter : MonoBehaviour
    {
    public GameObject projectilePrefab;
    public float spawnTimer = 2.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer = spawnTimer + Time.deltaTime;
        if (spawnTimer > 2)
        {
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, -5), projectilePrefab.transform.rotation);
            spawnTimer = 0.0f;
        }
    }
}
