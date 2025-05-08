
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class Character : MonoBehaviour
{
    [field:SerializeField] protected string Name { get; set; }
    [field:SerializeField] protected float Health { get; set; }

    public void TakeDamage(int TakeDamage) //T�t� methodia ei voida ylikirjoittaa aliluokassa kuten "Mage
    {
        Health -= TakeDamage;

        print($"{Name} sai {TakeDamage} vahinkoa");
    }
    public virtual void Attack() //T�m� methodi voidaan ylikirjoittaa aliluokassa kuten "Mage"
    {
        Debug.Log($"{Name} hy�kk��!");
        Debug.Log("Attack methodia ei ole ylikirjoittettu");
    }
}
