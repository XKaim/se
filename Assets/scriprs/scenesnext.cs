using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesnext : MonoBehaviour
{ 
    public void ChangeScene() 
    {
        SceneManager.LoadScene(1);
    } 

    public void Exit() 
    { 
        Application.Quit(); 
    } 
}

