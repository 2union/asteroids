using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollisionScript : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
