using UnityEngine;

public class Warrior : Character
{
    public int SwordDamage { get; private set; }

    public override void Attack()
    {
        Debug.Log($"{Name} heiluttaa miekkaa!");
        Debug.Log($"Attack methodi on ylikirjoitettu {Name} scriptissä");
    }
}
