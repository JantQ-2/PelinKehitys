using UnityEngine;
using UnityEngine.InputSystem;

public class AudioController : MonoBehaviour
{

    [SerializeField] private AudioClip audioClip;
    private void Update()
    {
         if (Keyboard.current.yKey.wasPressedThisFrame)
         {
            AudioManager.Instance.StopSound();
         }

         if (Keyboard.current.uKey.wasPressedThisFrame)
         {
            AudioManager.Instance.PlaySound(audioClip);
         }
    }
}
