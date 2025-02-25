using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionTest : MonoBehaviour
{
    [SerializeField] private GameObject Item;
    [SerializeField] private GameObject NPC;
    [SerializeField] private GameObject UFO;

    private Camera mainCamera;

    public void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        var fKey = Keyboard.current.fKey.wasPressedThisFrame;
        var gKey = Keyboard.current.gKey.wasPressedThisFrame;
        var rKey = Keyboard.current.rKey.wasPressedThisFrame;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            

            if (Physics.Raycast(ray, out RaycastHit hit, 100f))
            {
                

                var interactable = hit.collider.GetComponent<UFO>(); // K‰ytet‰‰n UFO-komponenttia

                if (interactable != null)
                {
                
                    interactable.Interact();
                }
                
            }
            
        }
    }

}
