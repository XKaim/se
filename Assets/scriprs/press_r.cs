using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press_r : MonoBehaviour
{
    public GameObject x;
        
    void Start()
    {
        x.SetActive(false);
    }

    void Update()
    {
        if(did_gg.l == true)
        {
            x.SetActive(true);
        }
    }
}
