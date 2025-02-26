using UnityEngine;

public interface IDamageable1
{
    public float Health { get; set; }
    public int Defence { get; set; }

    public void Die();
    public void TakeDamage();
    public void RestoreDamage();
}