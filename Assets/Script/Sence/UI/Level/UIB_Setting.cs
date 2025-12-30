using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIB_Setting : MonoBehaviour
{
     [SerializeField] UILevel_Manager manager;

    void Awake()
    {
        manager = FindAnyObjectByType<UILevel_Manager>();
    }
    public void PannelSetting()
    {
        manager.OnClickSetting();
    }

}
