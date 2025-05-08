using UnityEngine;
public enum WeaponType { Melee, Ranged, Magic }
[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapons/Weapon/Data")]
public class WeaponDataSO : ScriptableObject
{
    public string weaponName; // aseen nimi
    public WeaponType weaponType; // aseen tyyppi
    public string specialAbility; // erikoisominaisuus
    public int damage; // vahingon m��r�
    public float range; // hy�kk�ysalue
    public Sprite icon; // aseen kuva
}