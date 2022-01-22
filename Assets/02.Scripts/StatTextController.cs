using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StatTextController : MonoBehaviour
{
    // count up/down as the key enters/leaves the pedestal

    public TextMeshProUGUI keyText;

    public int keysIn;

    public int CountUp()
    {
        if (true) // if key is in the pedestal
        {
            keysIn++;
        }        

        return keysIn;
    }



    public void ShowCount()
    {
        keyText.SetText($"Current Keys : {keysIn}");
    }


    
}
