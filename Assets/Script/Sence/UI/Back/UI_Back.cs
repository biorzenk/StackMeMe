using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class UI_Back : MonoBehaviour
{
    [SerializeField] UI_Manager manager;

    public void ClickBack()
    {
        manager.OnClickBack();
    }
}
