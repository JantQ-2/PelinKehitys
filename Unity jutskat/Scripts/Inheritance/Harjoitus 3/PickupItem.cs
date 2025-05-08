using UnityEngine;

public class PickupItem : Interactable
{
    public GameObject pickupItem;
    public override void Interact()
    {
        Debug.Log("Keräsit esineen");
    }
}
