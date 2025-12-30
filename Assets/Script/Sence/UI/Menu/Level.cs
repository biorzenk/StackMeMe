using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public Button[] buttons;


     private void Awake()
    {
        int UnlockedLevels = PlayerPrefs.GetInt("UnlockedLevels", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < UnlockedLevels; i++)
        {
            buttons[i].interactable = true;
        }
    }     
    public void OpenLevel(int Level_id)
    {
        SceneType scene = (SceneType)Level_id;
        SceneLoaded.Instance.Load(scene);
    }


}
