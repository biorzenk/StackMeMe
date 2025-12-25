using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Menu_UiSetting : MonoBehaviour
{
    [SerializeField] UI_Manager manager;

    
    public void ClickSetting()
    {
        StartCoroutine(DelaySetting());
    }

    IEnumerator DelaySetting()
    {
        yield return new WaitForSeconds(0.2f);
        manager.OnClickSetting();
    }
}
