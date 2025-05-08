using UnityEngine;

public class ExplodingBarrel : MonoBehaviour, IDamageable1, IExplodable
{
    public float Health { get; set; }
    public int Defence { get; set; }
    public int Mass { get; set; }
    public int ExplosiveForce { get; set; }
    public int FuseDelay { get; set; }

    public void Die()
    {
        
    }

    public void Explode()
    {
        
    }

    public void RestoreDamage()
    {
        
    }

    public void TakeDamage()
    {
    
    }
}
