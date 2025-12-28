using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Ui_Play;
    public GameObject Ui_Setting;
    public GameObject Ui_Exit;

    public GameObject Ui_PanelLevel;
    public GameObject Ui_PanelSetting;

    public GameObject Ui_Back;
    bool isBack = false;


     Menu_AudioManager audioManager;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio_Menu").GetComponent<Menu_AudioManager>();
    }

    void Start()
    {
        Ui_Play.SetActive(true);
        Ui_Setting.SetActive(true);
        Ui_Exit.SetActive(true);

        Ui_PanelLevel.SetActive(false);
        Ui_PanelSetting.SetActive(false);

        isBack = false;
        Ui_Back.SetActive(false);
    }

    public void OnClickPanelLevel()
    {
        Ui_Play.SetActive(false);
        Ui_Setting.SetActive(false);
        Ui_Exit.SetActive(false);

        Ui_PanelLevel.SetActive(true);
        Ui_PanelSetting.SetActive(false);

        isBack = true;
        Ui_Back.SetActive(true);
        audioManager.PlaySFX(audioManager.button_Click_SFX);
    }


    public void OnClickSetting()
    {
        Ui_Play.SetActive(false);
        Ui_Setting.SetActive(false);
        Ui_Exit.SetActive(false);

        Ui_PanelLevel.SetActive(false);
        Ui_PanelSetting.SetActive(true);

        isBack = true;
        Ui_Back.SetActive(true);
        audioManager.PlaySFX(audioManager.button_Click_SFX);
    }

    public void OnClickBack()
    {
        if (isBack)
        {
            Ui_Play.SetActive(true);
            Ui_Setting.SetActive(true);
            Ui_Exit.SetActive(true);
            Ui_PanelLevel.SetActive(false);
            Ui_PanelSetting.SetActive(false);
            isBack = false;
            Ui_Back.SetActive(false);
            audioManager.PlaySFX(audioManager.button_Click_SFX);
        }
    }


    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }



}
