using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void PlayMap1()
    {
        Invoke("DelaySetting", 1f);
        SceneManager.LoadSceneAsync("Map_1");
    }
}
