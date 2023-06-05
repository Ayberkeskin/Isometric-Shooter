using Bullets;
using ObjectPoollings;
using UnityEngine;

namespace Weapons
{
    public class Weapon : MonoBehaviour,IWeapon
    {
        [SerializeField] WeaponData weaponData;
        [SerializeField] Transform firePoint;

        private float lastFireTime;

        private bool CanFire()
        {
            return (Time.time >= (lastFireTime + weaponData.FireRate) ? true : false);
        }

        public void Fire()
        {
            if (!CanFire())
                return;
            lastFireTime = Time.time;

            
            Bullet bullet = BulletPool.Instance.Dequeue();

            bullet
                .SetDamage(weaponData.Damage)
                .SetPosition(firePoint.position)
                .SetForward(firePoint.forward)
                .AddForce();
        }

        
    }

}