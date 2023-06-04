using UnityEngine;


namespace Targets
{
    public interface ITarget
    {
        bool CanTargetable { get; }
        void Hit(int damage);
        Transform GetTransform();
    }

}
