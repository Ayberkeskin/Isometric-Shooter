using ObjectPoollings;
using Targets;
using UnityEngine;

namespace Bullets
{
    public class Bullet : MonoBehaviour,IPoolObject
    {
        [SerializeField] float speed;
        [SerializeField] Rigidbody rb;

        private int damage=5;

      

        public void Hit(ITarget target)
        {
            target.Hit(damage);
        }

        public Bullet SetDamage(int damage)
        {
            this.damage = damage;

            return this;
        }

        public Bullet SetPosition(Vector3 position)
        {
            transform.position = position;

            return this;
        }

        public Bullet SetForward(Vector3 forward)
        {
            transform.forward = forward;

            return this;
        }
        public Bullet AddForce()
        {
            rb.AddForce(transform.forward.normalized * speed);
            return this;
        }

        public void DequeuSettings()
        {
            gameObject.SetActive(true);
            SetTransformParent(null);
        }

        public void EnqueueSettings()
        {
            gameObject.SetActive(false);
            SetTransformParent(BulletPool.Instance.GetTransform());
            SetPosition(Vector3.zero);

            rb.velocity = Vector3.zero;
        }

        private void SetTransformParent(Transform parent)
        {
            transform.parent = parent;
        }
    }

}
