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

        private ObjectPool<GameObject> Pool;

        private void Awake()
        {
            Pool = new ObjectPool<GameObject>(
                OnCreatePoolObject,
                OnGetFromPool,
                OnReleaseToPool,
                OnDestroyPooledObject
                );
        }

        public GameObject OnCreatePoolObject()
        {
            return Instantiate(_bulletPrefab.gameObject);
        }

        private void OnGetFromPool(GameObject go)
        {
            go.SetActive(true);
        }

        private void OnReleaseToPool(GameObject go)
        {
            go.SetActive(false);
        }

        private void OnDestroyPooledObject(GameObject go)
        {
            Destroy(go);
        }

        public GameObject GetGameObject(Bullet go, Vector3 position, Quaternion rotation)
        {
            _bulletPrefab = go.GetComponent<Bullet>();
            var obj = Pool.Get();
            var transform = obj.transform;
            transform.position = position;
            transform.rotation = rotation;
            return obj;
        }

        public void ReleaseGameObject(GameObject go)
        {
            Pool.Release(go);
        }
    }
}