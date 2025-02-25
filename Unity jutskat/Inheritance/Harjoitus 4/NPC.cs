using UnityEngine;

public class NPC : Interactable
{
    public GameObject npc;
    public override void Interact()
    {
        Debug.Log("Olen NPC hahmo");
    }
}
