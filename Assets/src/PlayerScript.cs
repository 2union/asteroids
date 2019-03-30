using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float horizontalTilt;
    public float verticalTilt;
    public Boundary boundary;
    public GameObject laserShot;
    public GameObject laserGun;
    public float shotDelay;
    private float nextShot;
    private Rigidbody ship;

    // Start is called before the first frame update
    void Start()
    {
        this.ship = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.ship.rotation = Quaternion.Euler(-this.ship.velocity.z * this.verticalTilt, 0, -this.ship.velocity.x * this.horizontalTilt);

        bool canShot = Time.time > this.nextShot;

        if (Input.GetButton("Fire1") && canShot)
        {
            this.nextShot = Time.time + this.shotDelay;

            Instantiate(this.laserShot, this.laserGun.transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        this.ship.velocity = new Vector3(moveHorizontal, 0, moveVertical) * this.speed;

        float xPosition = Mathf.Clamp(this.ship.position.x, this.boundary.xMin, this.boundary.xMax);
        float zPosition = Mathf.Clamp(this.ship.position.z, this.boundary.zMin, this.boundary.zMax);
        
        this.ship.position = new Vector3(xPosition, 0, zPosition);
    }
}
