using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_UiSetting : MonoBehaviour
{
    [SerializeField] UI_Manager manager;

    public void ClickSetting()
    {
        manager.OnClickSetting();
    }
}
