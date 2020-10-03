using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Drop1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Hit");
            SceneManager.UnloadSceneAsync("Stage 1");
            SceneManager.LoadScene("SceneStageSel");
        }
    }
}
