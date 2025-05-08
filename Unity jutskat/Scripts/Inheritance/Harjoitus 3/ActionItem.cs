using UnityEngine;

public class ActionItem: Interactable
{

    [field: SerializeField]public GameObject actionItem;
    public override void Interact()
    {
        Debug.Log("Olen Action Item.");
    }
}
