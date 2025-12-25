using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_UIPlay : MonoBehaviour
{
    [SerializeField] UI_Manager manager;


    public void OnClickPlay()
    {
        StartCoroutine(DelayOpenLevel());
    }

    IEnumerator DelayOpenLevel()
    {
        yield return new WaitForSeconds(0.2f);
        manager.OnClickPanelLevel();
    }
}
