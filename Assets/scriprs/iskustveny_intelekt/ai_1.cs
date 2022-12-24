using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
    public bool bl;
    public Rigidbody2D rb;
    public bool bc = false;
    public float speed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        bl = stopludi.st;
        if (bc == true)
        {

            rb.velocity = Vector3.down * speed;
        }
        if (stopludi.st == true)
        {
            speed = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            bc = true;
        }
        
    }

}
