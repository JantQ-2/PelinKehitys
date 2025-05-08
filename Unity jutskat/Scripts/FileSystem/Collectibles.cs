using System;
using TMPro;
using UnityEngine;

public class Collectibles : MonoBehaviour
{

    [SerializeField] string itemName = "DefaultItemName";
    public TextMeshProUGUI textComponent;
    public FileManager fileManager;

    public void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(gameObject);
        UpdateText($"{itemName} collected");
        GetComponent<Collider>().enabled = false;
    }

    void UpdateText(string newText)
    {
        if (textComponent != null)
        {
            textComponent.text += newText + "\n";
        }
        fileManager.UpdateTextFile($"{newText} At: {DateTime.Now} \n");
    }


}
