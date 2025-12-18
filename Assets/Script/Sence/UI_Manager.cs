using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject UiPlayer;
    public GameObject UiLevel;

    void Start()
    {
        UiPlayer.SetActive(true);
        UiLevel.SetActive(false);
    }

    public void OnClickPlay()
    {
        UiPlayer.SetActive(false);
        UiLevel.SetActive(true);
    }

    public void OnClickBack()
    {
        UiPlayer.SetActive(false);
        UiLevel.SetActive(true);
    }

}
