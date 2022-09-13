using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerOutText : MonoBehaviour
{
    public Text menu;
    
    public void InputMenu (int value)
    {
        switch (value) 
        {
            case 0: 
                menu.text = "Option A";
                break;
            case 1:
                menu.text = "Option B";
                break;
            case 2:
                menu.text = "Option C";
                break;
            case -1:
                menu.text = "";
                break;
        }
    }
}