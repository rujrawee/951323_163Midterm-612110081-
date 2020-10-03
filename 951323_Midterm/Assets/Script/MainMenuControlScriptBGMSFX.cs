using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenuControlScriptBGMSFX : MonoBehaviour//, IPointerEnterHandler
{
    [SerializeField] Button buttonStageSel;
    [SerializeField] Button buttonOptions;
    [SerializeField] Button buttonCredit;
    [SerializeField] Button buttonExit;

    AudioSource audiosourceButtonUI;
    [SerializeField] AudioClip audioclipHoldOver;

    // Use this for initialization
    void Start()
    {
        /*this.audiosourceButtonUI = this.gameObject.AddComponent<AudioSource>();
        this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer.FindMatchingGroups("UI")[0];*/
        
        buttonStageSel.onClick.AddListener(delegate { StageSelButtonClick(buttonStageSel); });
        buttonOptions.onClick.AddListener(delegate { OptionsButtonClick(buttonOptions); });
        buttonCredit.onClick.AddListener(delegate { CreditButtonClick(buttonCredit); });
        buttonExit.onClick.AddListener(delegate { ExitButtonClick(buttonExit); });

        if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();
    }

    /*public void OnPointerEnter(PointerEventData eventData)
    {
        if (audiosourceButtonUI.isPlaying)
        audiosourceButtonUI.Stop();
        
        audiosourceButtonUI.PlayOneShot(audioclipHoldOver);
    }*/

    public void StageSelButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneStageSel");
    }

    public void OptionsButtonClick(Button button)
    {
        if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void CreditButtonClick(Button button)
    {
        SceneManager.LoadScene("Credit");
    }
    public void ExitButtonClick(Button button)
    {
            Application.Quit();
    }
}
