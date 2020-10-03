using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Hit");
            SceneManager.UnloadSceneAsync("Stage 2");
            SceneManager.LoadScene("SceneMainMenu");
        }
    }
}