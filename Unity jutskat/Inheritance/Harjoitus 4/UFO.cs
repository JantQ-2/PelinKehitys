using UnityEngine;

public class UFO : ActionItem
{
    [SerializeField] private string[] dialogueLines;
    [SerializeField] private string ufoName;
    public override void Interact()
    {
        base.Interact();
        if (DialogueSystem.Instance != null)
        {
            DialogueSystem.Instance.AddNewDialoque(dialogueLines, ufoName);
        }
    }
}
