using Targets;
using UnityEngine;

namespace Bullets
{
    public class BulletTrigger : MonoBehaviour
    {
        [SerializeField] Bullet bullet;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<ITarget>(out ITarget target))
            {
                bullet.Hit(target);
            }

            Destroy(gameObject);
        }

    }

}
