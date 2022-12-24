using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class schet : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = gun.amm.ToString();
    }
}
