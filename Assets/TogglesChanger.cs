using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglesChanger : MonoBehaviour
{
    public Text textToEdit;
    public Toggle toggleFirst;
    public Toggle toggleSecond;
    public Toggle toggleThird;

    public void ChangeText()
    {
        if (toggleFirst.isOn)
        {
            textToEdit.text = " First ";
            return;
        }
        if (toggleSecond.isOn)
        {
            textToEdit.text = " Second ";
            toggleFirst.isOn = false;
            toggleThird.isOn = false;
            return;
        }
        if (toggleThird.isOn)
        {
            textToEdit.text = " Third ";
            toggleFirst.isOn = false;
            toggleSecond.isOn = false;
            return;
        }
    }
}
