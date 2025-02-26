using UnityEngine;

public class EnemyUnit : MonoBehaviour, IMovable1, IUnitStats, IDamageable1
{
    public int MoveSpeed { get; set; }
    public float Acceleration { get; set; }
    public float Strenght { get; set; }
    public int Dexterity { get; set; }
    public float Endurance { get; set; }
    public float Health { get; set; }
    public int Defence { get ; set ; }

    public void Die()
    {
        
    }

    public void GoForward()
    {
        
    }

    public void RestoreDamage()
    {
        
    }

    public void Reverse()
    {
        
    }

    public void TakeDamage()
    {
        
    }

    public void TurnLeft()
    {
        
    }

    public void TurnRight()
    {
        
    }
}
