using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float rotationSpeed;
    public float minSpeed;
    public float maxSpeed;

    private Rigidbody asteroid;
    
    // Start is called before the first frame update
    void Start()
    {
        this.asteroid = GetComponent<Rigidbody>();
        this.asteroid.angularVelocity = Random.insideUnitSphere * this.rotationSpeed;
        
        this.asteroid.velocity = Vector3.back * Random.Range(this.minSpeed, this.maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
