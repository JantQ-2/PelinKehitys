using SingeltonScore;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreController : MonoBehaviour
{
    private void Update()
    {
        if (Keyboard.current.tKey.wasPressedThisFrame);
        {
            ScoreManager.Instance.score += 10;
            Debug.Log(ScoreManager.Instance.score);
        }
    }
}
