using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterScript : MonoBehaviour
{
    public float minDelay;
    public float maxDelay;

    public GameObject asteroid;

    private float nextSpawn;
    private float asteroidCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > this.nextSpawn)
        {
            float wave = Random.Range(1, this.asteroidCount);

            for (int i = 0; i < wave; i++)
            {
                float randomXPosition = Random.Range(-transform.localScale.x/2, transform.localScale.x/2);
            
                Vector3 startPosition = new Vector3(randomXPosition, 0, transform.position.z);

                Instantiate(this.asteroid, startPosition, Quaternion.identity);
            }
            
            this.nextSpawn = Time.time + Random.Range(this.minDelay, this.maxDelay);

            this.asteroidCount += 0.1f;
        }
    }
}
