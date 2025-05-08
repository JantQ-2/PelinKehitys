using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponDataSO weaponData;
    public void Attack()
    {
        Debug.Log("Ase: " + weaponData.weaponName + ", Vahinko: " +
        weaponData.damage);
    }

}
