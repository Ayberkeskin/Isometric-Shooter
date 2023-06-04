using Targets;
using UnityEngine;

namespace Bullets
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] Rigidbody rb;

        private int damage=5;

        private void Start()
        {
            rb.AddForce(transform.forward.normalized*speed);
        }

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
    }

}
