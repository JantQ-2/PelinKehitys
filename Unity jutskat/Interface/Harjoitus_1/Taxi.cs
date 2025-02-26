using UnityEngine;
using UnityEngine.InputSystem;

public class Taxi : MonoBehaviour
{
    public int speed = 50;
    public int turnSpeed = 100;
    public float forwardInput;
    public float horizontalInput;

    public int damageAmount = 5;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        MoveTaxi(forwardInput, horizontalInput);

        
    }

    public void OnCollisionEnter(Collision collision)
    {
        IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();

        if (damageable != null)
        {
            damageable.TakeDamage(damageAmount);
            damageable.TakeDamage(damageAmount);
        }
    }
    public void MoveTaxi(float forwardInput, float horizontalInput)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
