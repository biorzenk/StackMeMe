using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Again : MonoBehaviour
{
    [SerializeField] UILevel_Manager manager;

    public void ClickAgain()
    {
        manager.OnClickReplay();
    }


}
