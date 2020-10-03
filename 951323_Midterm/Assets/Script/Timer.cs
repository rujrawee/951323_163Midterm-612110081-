﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30;
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            //Debug.Log("Time has run out!");
            SceneManager.UnloadSceneAsync("Stage 1");
            SceneManager.LoadScene("SceneStageSel");
        }
    }
}
