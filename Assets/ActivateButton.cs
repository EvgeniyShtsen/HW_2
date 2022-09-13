using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ActivateButton : MonoBehaviour
{ 
    public Button disabler;

    public void ButtonActivate()
    {
        disabler.gameObject.SetActive(false);
    }
}
