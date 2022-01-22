using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRenderOnOff : MonoBehaviour
{
    public GameObject uiToSwitch;

    public void TurnON()
    {
        if (uiToSwitch.activeInHierarchy == false)
        {
            uiToSwitch.SetActive(true);
        }
    }

    public void TurnOFF()
    {
        if (uiToSwitch.activeInHierarchy == true)
        {
            uiToSwitch.SetActive(false);
        }
    }
}
