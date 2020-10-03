using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelManagement : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button buttonStage1;
    [SerializeField] Button buttonStage2;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });
        buttonStage1.onClick.AddListener(delegate { Stage1(buttonStage1); });
        buttonStage2.onClick.AddListener(delegate { Stage2(buttonStage2); });
    }

    public void Stage1(Button button)
    {
        SceneManager.LoadScene("Stage 1");
    }
    public void Stage2(Button button)
    {
        SceneManager.LoadScene("Stage 2");
    }
    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSel");
        SceneManager.LoadScene("SceneMainMenu");
        //SingletonGameApplicationManager.Instance.IsOptionMenuActive = false;
    }
}
