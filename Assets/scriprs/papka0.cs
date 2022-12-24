using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papka0 : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;

    void Start()
    {
        p2.SetActive(false);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        p1.SetActive(false);
        p2.SetActive(true);

    }
}
