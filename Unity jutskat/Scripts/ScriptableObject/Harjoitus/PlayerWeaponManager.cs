using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    // Nykyinen ase (pakollinen)
    public Weapon currentWeapon;
    // Aseista pelaajan uudella aseella
    public void EquipWeapon(WeaponDataSO newWeaponData)
    {
        // Tarkistaa ett� pelaajalla on v�hint��n oletusase
        if (currentWeapon != null)
        {
            // Vaihtaa nykyisen aseen asedatan
            currentWeapon.weaponData = newWeaponData;
            Debug.Log("Aseistettu: " + newWeaponData.weaponName);
        }
        else // Oletusase puuttuu
        {
            Debug.LogWarning("Oletus ase puuttuu!");
        }
    }
    void Update()
    {
        // Aseella teht�v� hy�kk�ys
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentWeapon.Attack();
        }
    }
}
