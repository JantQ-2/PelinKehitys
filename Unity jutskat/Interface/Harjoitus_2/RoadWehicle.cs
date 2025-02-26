using UnityEngine;
using UnityEngine.LightTransport;

public class RoadWehicle : MonoBehaviour, IMoveable, ITurnable
{

    public float forwardInput;
    public float horizontalInput;

    public int speed =25;
    public int turnSpeed = 250;
    public void TurnLeft()
    {
        transform.Rotate(Vector3.down, Time.deltaTime * turnSpeed);
    }

    public void TurnRight()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
    }

    public void GoForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void Reverse()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

}
