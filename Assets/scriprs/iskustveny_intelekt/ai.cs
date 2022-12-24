using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai_1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool bc = false;
    public float speed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        if (bc == true)
        {
            rb.velocity = Vector3.down * speed;
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
