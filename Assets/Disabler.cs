using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disabler : MonoBehaviour
{
    public Button disabler;
    public Button buttonOne;
    public Button buttonTwo;

    public void ButtonDisabler()
    {
        buttonOne.interactable = false;
        buttonTwo.interactable = false;
    }
}
