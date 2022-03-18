using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    static float score = 0;
    private float flag = 0.0f;
    static int ju87hp = 5;
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
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            flag = 1.0f;
        }
        if(other.gameObject.CompareTag("Ju87"))
        {
            ju87hp -= 1;
            Destroy(gameObject);
        }
        if(ju87hp == 0)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            score = score + 3;
            ju87hp += 5;
        }
        if(flag == 1.0f)
        {
            score = score + 1;
            flag = 0.0f;
        }
        Debug.Log("score: " + score + " ju87hp: " + ju87hp);
        //Debug.Log("ju87hp: " + ju87hp);
         //var explosion = Instantiate(explosionPrefab);
        // Destroy(explosionPrefab);
    }


}

