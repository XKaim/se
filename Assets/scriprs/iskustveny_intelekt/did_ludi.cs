using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class did_ludi : MonoBehaviour
{
    public GameObject m;
    public GameObject s;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "pula")
        {
            m.SetActive(true);
            s.SetActive(false);
            gun_ai.speed = 0;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
