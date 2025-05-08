using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject Mage;
    [SerializeField] private GameObject Warrior;

    private void Update()
    {
        var gKey = Keyboard.current.gKey.wasPressedThisFrame;
        var hKey = Keyboard.current.hKey.wasPressedThisFrame;

        var tKey = Keyboard.current.tKey.wasPressedThisFrame;
        var yKey = Keyboard.current.yKey.wasPressedThisFrame;

        if (gKey) { Mage.GetComponent<Mage>().TakeDamage(1); }
        // Yllä ja alla olevat tavat ovat molemmat samanlaiset mutta näyttävät eriltäs
        if (hKey) 
        { 
            Warrior.GetComponent<Warrior>().TakeDamage(2); 
        }

        if (yKey)
        {
            Warrior.GetComponent<Warrior>().Attack();
        }

        if (tKey)
        {
            Mage.GetComponent<Mage>().Attack();
        }
    }
}
