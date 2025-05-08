using UnityEngine;

public class Mage : Character
    //Mage perii kaikki "Character" scriptiss‰ olevat asiat myˆs "Monobehavior" scriptin
{
    public int MagicDamage { get; private set; }

    // summary n‰ytt‰‰ "Attack" methodin Playercontrollerissa kun menee "Attack" Methodiin

    /// <summary>
    /// Heitt‰‰ tuli pallon
    /// </summary>

    public override void Attack()
    {
        
        Debug.Log($"{Name} k‰ytt‰‰ loitsun");
        Debug.Log($"Attack methodi on ylikirjoitettu {Name} scriptiss‰");
    }
}
