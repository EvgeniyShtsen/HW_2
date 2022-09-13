using UnityEngine;
using UnityEngine.UI;

public class ButtonOne : MonoBehaviour
{
    public Text textToEdit;
    public Button buttonOne;
   
    public void ChangeText()
    {
        textToEdit.text = "One was clicked";
    }
}