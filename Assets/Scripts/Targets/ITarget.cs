using UnityEngine;


namespace Targets
{
    public interface ITarget
    {
        public bool IsAlive();
        public Transform GetTransform();
    }

}
