using UnityEngine.InputSystem;

public class Train : RailWehicle
{
    public float forwardInput;

    private void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            GoForward();
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            Reverse();
        }
    }
}
