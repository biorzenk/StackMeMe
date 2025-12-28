using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ClosePanel : MonoBehaviour
{
    [SerializeField] UILevel_Manager manager;

    public void OnClose ()
    {
        manager.OnClickCloseSetting ();
        Debug.Log("Close Setting Panel");
    }
}
