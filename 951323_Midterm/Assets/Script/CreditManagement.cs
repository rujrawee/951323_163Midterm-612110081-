using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditManagement : MonoBehaviour
{
    [SerializeField] Button _backButton;
    // Start is called before the first frame update
    void Start()
        {
            _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });
        }
        public void BackButtonClick(Button button)
        {
            SceneManager.UnloadSceneAsync("Credit");
            SceneManager.LoadScene("SceneMainMenu");
            //SingletonGameApplicationManager.Instance.IsOptionMenuActive = false;
        }

}