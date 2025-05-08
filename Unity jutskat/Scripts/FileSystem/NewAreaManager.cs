using System;
using TMPro;
using UnityEngine;

public class NewAreaManager : MonoBehaviour
{

    [SerializeField] string areaName = "DefaultAreaName";
    public FileManager fileManager;
    public TextMeshProUGUI textComponent;
    public void OnTriggerEnter(Collider other)
    {
        UpdateText($"Entered Outside");
        GetComponent<Collider>().enabled = false;
    }

    void UpdateText(string newText)
    {
        if (textComponent != null)
        {
            textComponent.text += newText + "\n";
        }

        fileManager.UpdateTextFile($"Entered Outside At :{DateTime.Now}\n Area Name {areaName} \n");
    }
}
