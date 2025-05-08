using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour 
{ 
    private void Update() 
    { 
        var eKey = Keyboard.current.eKey.wasPressedThisFrame; 
        if (eKey) 
        { 
            HealthManager1.Instance.TakeDamage(10); 
        } 
    } 
}

