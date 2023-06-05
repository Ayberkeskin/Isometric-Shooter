using Bullets;
using UnityEngine;

namespace ObjectPoollings
{
    public class BulletPool : ObjectPool<Bullet>
    {
        #region Singleton
        private static BulletPool instance;
        public static BulletPool Instance { get => instance;  }

        public override void Awake()
        {
            if (instance != null)
                Destroy(gameObject);
            instance = this;

            base.Awake();
        }
        #endregion
        public override void DequeueSettings(Bullet pooledObject)
        {
            pooledObject.DequeuSettings();
        }

        public override void EnqueueSettings(Bullet pooledObject)
        {
            pooledObject.EnqueueSettings();
        }
        public Transform GetTransform() 
        { 
            return transform;
        }
    }

}