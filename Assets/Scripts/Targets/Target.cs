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
