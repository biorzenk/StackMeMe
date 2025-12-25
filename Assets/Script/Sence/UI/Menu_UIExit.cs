using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_UIExit : MonoBehaviour
{
    [SerializeField] UI_Manager manager;

    public void ClickExit()
    {
        StartCoroutine(DelayExit());
    }

    IEnumerator DelayExit()
    {
        yield return new WaitForSeconds(0.2f);
        manager.OnClickExit();
    }
}

