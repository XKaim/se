using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class glavnoe_menu : MonoBehaviour
{
    public GameObject a;
    public static bool c;

    void Start()
    {
        a.SetActive(false);
        c = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && did_gg.l == false)
        {
            a.SetActive(true);
            c = true;
            player.speed = 0;
        }

    }

    public void R()
    {
        a.SetActive(false);
        c = false;
        player.speed = 400;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        c = false;
    }

}
