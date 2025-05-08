
using UnityEngine.InputSystem;

public class Car : RoadWehicle
{

    private void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            GoForward();
        }

        if (Keyboard.current.sKey.isPressed)
        {
            Reverse();
        }

        if (Keyboard.current.aKey.isPressed)
        {
            TurnLeft();
        }

        if (Keyboard.current.dKey.isPressed)
        {
            TurnRight();
        }
    }    
}
