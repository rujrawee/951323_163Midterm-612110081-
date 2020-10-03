using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    public float timeRemaining = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.UnloadSceneAsync("Splash");
            SceneManager.LoadScene("SceneMainMenu");
        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            //Debug.Log("Time has run out!");
            SceneManager.UnloadSceneAsync("Splash");
            SceneManager.LoadScene("SceneMainMenu");
        }
    }
    
}
