using UnityEngine;

namespace Targets
{
    public class Target : MonoBehaviour, ITarget
    {
        private void OnEnable()
        {
            TargetManager.AddTarget(this);
        }
        private void OnDisable()
        {
            TargetManager.RemoveTarget(this);
        }
        public void TakeDamage(int damage)
        {
            Debug.Log($"{name} take{damage} damage");
        }

        public Transform GetTransform()
        {
            return transform;
        }

        public bool IsAlive()
        {
            return true;
        }

     
    }
}
