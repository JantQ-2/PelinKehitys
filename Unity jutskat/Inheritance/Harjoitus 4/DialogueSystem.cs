using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem Instance { get; private set; }

    

    public string name {  get; private set; }

    private List<string> dialogueLines = new List<string>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddNewDialoque(string[] lines, string name)
    {
        this.name = name;
        dialogueLines.Clear();
        dialogueLines.AddRange(lines);
        CreateDialogue();
    }

    public void CreateDialogue()
    {
        foreach (string line in dialogueLines)
        {
            print($"{name}: {line}");
        }
    }
    
}
