using TMPro;
using UnityEngine;

public class TextModifier : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    
    void Start()
    {
        if (textComponent != null)
        {
            textComponent.text = "<Tallennettu Data> \n";
        }
        else
        {
            Debug.LogError("(textComponent != null)");
        }
    }

    public void UpdateText(string newText)
    {
        if (textComponent != null)
        {
            textComponent.text = newText + "\n";
        }
    }
}
