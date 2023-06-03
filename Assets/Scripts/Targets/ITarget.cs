using UnityEngine;


namespace Targets
{
    public interface ITarget
    {
         void TakeDamage(int damage);
         bool IsAlive();
         Transform GetTransform();
    }

}
