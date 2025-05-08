
using UnityEngine;

public class mouse : MonoBehaviour, IDamageable
{
    public GameObject effect;
    public int health = 20;
    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject);
            if (effect)
            {
                Instantiate(effect, transform.position, Quaternion.identity);

            }
        }
    }
}
