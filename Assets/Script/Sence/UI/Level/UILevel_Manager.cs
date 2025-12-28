using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevel_Manager : MonoBehaviour
{
    public GameObject Panel_Setting;
    public GameObject B_Setting;

    void Start()
    {
        Panel_Setting.SetActive(false);
        B_Setting.SetActive(true);
        Time.timeScale = 1f;
    }

    public void OnClickSetting()
    {
        Time.timeScale = 0f;
        Panel_Setting.SetActive(true);
        B_Setting.SetActive(false);
        Debug.Log("Setting Open");
    }

    public void OnClickCloseSetting()
    {
        Time.timeScale = 1f;
        Panel_Setting.SetActive(false);
        B_Setting.SetActive(true);
        Debug.Log("Setting Close");
    }

}
