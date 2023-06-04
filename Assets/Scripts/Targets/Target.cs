using UnityEngine;
using UnityEngine.Events;

namespace Targets
{
    public class Target : MonoBehaviour, ITarget
    {

        [Header("Component")]
        [SerializeField] Collider col;
        [SerializeField] Rigidbody rb;

        [Header("Event")]
        public UnityEvent<int> OnHit;

        private bool canTargetable = true;
        public bool CanTargetable => canTargetable;

        private void OnEnable()
        {
            TargetManager.AddTarget(this);
        }
        private void OnDisable()
        {
            TargetManager.RemoveTarget(this);
        }
        public void Hit(int damage)
        {
            OnHit?.Invoke(damage);
        }

        public Transform GetTransform()
        {
            return transform;
        }

        public void CanTargetAnyMore()
        {
            canTargetable = false;
            col.enabled = false;
            rb.isKinematic = true;
        }
     
    }
}
