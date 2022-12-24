using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class did_gg : MonoBehaviour
{
    public GameObject trup;
    public GameObject gg;
    public static bool l = false;
    public bool w;
    void Start()
    {
        l= false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ya_ymer_prosti")
        {
            l = true;
            w = l;
            trup.SetActive(true);
            gg.SetActive(false);
            gun_ai.speed = 0;
        }
    }
}
