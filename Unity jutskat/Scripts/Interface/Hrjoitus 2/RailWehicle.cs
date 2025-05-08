using UnityEngine;

public class RailWehicle : MonoBehaviour, IMoveable
{

    public int speed = 20;
    public void GoForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void Reverse()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

}
