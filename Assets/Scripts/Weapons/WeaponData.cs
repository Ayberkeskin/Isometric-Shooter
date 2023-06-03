using Bullets;
using UnityEngine;

[CreateAssetMenu(menuName ="Weapon Data",fileName ="Weapon Data")]
public class WeaponData : ScriptableObject
{
    [SerializeField] Bullet bullet;
    [SerializeField] int damage;
    [SerializeField] float fireRate;

    public Bullet Bullet { get => bullet; }
    public int Damage { get => damage; }
    public float FireRate { get => fireRate; }
}
