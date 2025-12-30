using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevel_Manager : MonoBehaviour
{

    public GameObject Panel_Setting;
    public GameObject B_Setting;
    public GameObject Pannel_Dead;
    public GameObject B_Again;
    public GameObject B_Exit;
    public GameObject B_Next;


    bool isDeadShown = false;

    void Awake()
    {
        Time.timeScale = 1f;

        Panel_Setting.SetActive(false);
        B_Setting.SetActive(true);

        Pannel_Dead.SetActive(false);


        B_Again.SetActive(false);
        B_Exit.SetActive(false);
        B_Next.SetActive(false);
    }

    public void OnClickSetting()
    {
        Time.timeScale = 0f;
        Panel_Setting.SetActive(true);
        B_Setting.SetActive(false);
        Debug.Log("Setting Open");

        Pannel_Dead.SetActive(false);

        B_Again.SetActive(false);
        B_Exit.SetActive(false);
        B_Next.SetActive(false);

    }

    public void OnClickCloseSetting()
    {
        Time.timeScale = 1f;
        Panel_Setting.SetActive(false);
        B_Setting.SetActive(true);
        Debug.Log("Setting Close");

        Pannel_Dead.SetActive(false);

        B_Again.SetActive(false);
        B_Exit.SetActive(false);
        B_Next.SetActive(false);
    }

    public void PannelDead()
    {
        Time.timeScale = 0f;

        if (Panel_Setting) Panel_Setting.SetActive(false);
        if (B_Setting) B_Setting.SetActive(false);
        if (Pannel_Dead) Pannel_Dead.SetActive(true);
        Debug.Log("Panel_Dead Open");

        if (isDeadShown) return;
        isDeadShown = true;

        if (B_Again) B_Again.SetActive(true);
        if (B_Exit) B_Exit.SetActive(true);
        if (B_Next) B_Next.SetActive(false);
    }

    public void OnClickReplay()
    {
        Time.timeScale = 1f;
        isDeadShown = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
