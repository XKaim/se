using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podckazki : MonoBehaviour
{
    public GameObject qwerty;

    public void gul()
    {
        qwerty.SetActive(false);
        glavnoe_menu.c = false;
        player.speed = 400;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
