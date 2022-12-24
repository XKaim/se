using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopludi : MonoBehaviour
{
    public static bool st;

    void Start()
    {
        st = false;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "pula")
        {
            st = true;
        }
        if (other.tag == "Stop")
        {
            st = true;
        }
    }
}
