using UnityEngine;
using UnityEngine.Pool;

namespace UniversWar
{
    /// <summary>
    /// íeÇÃÉvÅ[Éã
    /// </summary>
    public class BulletPool : MonoBehaviour
    {
        [SerializeField]
        private Bullet _bulletPrefab;

        private ObjectPool<Bullet> Pool;

        private void Awake()
        {
            Pool = new ObjectPool<Bullet>(
                OnCreatePoolObject,
                OnGetFromPool,
                OnReleaseToPool,
                OnDestroyPooledObject
                );
        }

        public Bullet OnCreatePoolObject()
        {
            return Instantiate(_bulletPrefab);
        }

        private void OnGetFromPool(Bullet go)
        {
            go.gameObject.SetActive(true);
        }

        private void OnReleaseToPool(Bullet go)
        {
            go.gameObject.SetActive(false);
        }

        private void OnDestroyPooledObject(Bullet go)
        {
            Destroy(go.gameObject);
        }

        public Bullet GetBullet(Vector3 position, Quaternion rotation)
        {
            var bullet = Pool.Get();
            var transform = bullet.transform;
            transform.position = position;
            transform.rotation = rotation;
            return bullet;
        }

        public void ReleaseGameObject(Bullet go)
        {
            Pool.Release(go);
        }
    }
}