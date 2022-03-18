using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private bool death = false;

    //public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            death = true;
        }
        if (death == true)
        {
            Time.timeScale = 0;
        }
    }
        
}
        
        //var explosion = Instantiate(explosionPrefab);
        //Destroy(explosionPrefab);
    
