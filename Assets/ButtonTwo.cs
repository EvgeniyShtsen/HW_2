using UnityEngine;
using UnityEngine.UI;

public class ButtonTwo : MonoBehaviour
{
    public Text textToEdit;
    public Button buttonTwo;

    public void ChangeText()
    {
        textToEdit.text = "Two was clicked";
    }
}