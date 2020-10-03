﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplicationManager : MonoBehaviour
{
    static public GameApplicationManager Instance 
    {
        get 
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType <GameApplicationManager >();
                GameObject container = new GameObject("GameApplicationManager");
                _instance = container.AddComponent <GameApplicationManager >();
            }
            return _instance;
        }
    }
    static protected GameApplicationManager _instance = null;
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }
    /////////// Get/Set property declaration ////////////
    public bool IsOptionMenuActive
    {
        get { return _isOptionMenuActive; }
        set { _isOptionMenuActive = value; }
    }
    protected bool _isOptionMenuActive = false;
    //////////////////////////////

    /////////// Shorter version of Get/Set property declaration ////////////
    // The C# compiler will generate the same as the above for you, automatically.
    public int DifficultyLevel{get;set;}
    public bool MusicEnabled{get;set;}
    public bool SFXEnabled{get;set;}
    //////////////////////////////

}
