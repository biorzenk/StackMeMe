using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIB_Setting : MonoBehaviour
{
     [SerializeField] UILevel_Manager manager;

    public void PannelSetting()
    {
        manager.OnClickSetting();
    }

}
