using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIH_Setting : MonoBehaviour
{
    
    public void OnClickHome()
    {
        Time.timeScale = 1f;
        SceneLoaded.Instance.Load(SceneType.Menu);

    }
}
