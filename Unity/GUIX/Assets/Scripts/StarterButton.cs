﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarterButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onStartClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void goGame()
    {
        SceneManager.LoadScene("TipScreen");
    }
}
