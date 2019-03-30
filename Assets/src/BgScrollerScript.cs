using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScrollerScript : MonoBehaviour
{
    public float speed;

    private Vector3 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        this.startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * this.speed, transform.localScale.y);

        transform.position = this.startPosition + Vector3.back * newPosition;
    }
}
