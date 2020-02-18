using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawner : MonoBehaviour
{
    public GameObject obstacle;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
