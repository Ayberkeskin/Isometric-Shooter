using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    public class WeaponHandler : MonoBehaviour
    {
        [SerializeField] List<Weapon> weapon;
        public IWeapon GetWeapon()
        {
            return weapon[0];
        }

    }

}
