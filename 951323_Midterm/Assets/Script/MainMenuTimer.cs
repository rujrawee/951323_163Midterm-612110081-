using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTimer : MonoBehaviour
{
    public float timeRemaining = 5;
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
            if (Input.anyKey)
            {
                timeRemaining = 5;
            }
        }
        else
        {
            //Debug.Log("Time has run out!");
            SceneManager.UnloadSceneAsync("SceneMainMenu");
            SceneManager.LoadScene("Splash");
        }


    }
}
