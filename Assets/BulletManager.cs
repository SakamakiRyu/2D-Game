using System.Collections.Generic;
using UnityEngine;
using DragonPackage;

namespace UniversWar
{
    public class BulletManager : MonoBehaviour, IBulletManager
    {
        [SerializeField]
        private Bullet _bulletPrefab;

        [SerializeField]
        private int _defaultCapacity;

        private List<Bullet> _bulletList;

        private void Start()
        {
            CreateBulletPool();
        }

        private void OnEnable()
        {
            ServiceLocator<IBulletManager>.Bind(this);
        }

        private void OnDisable()
        {
            ServiceLocator<IBulletManager>.UnBind(this);
        }

        private void CreateBulletPool()
        {
            _bulletList = new List<Bullet>(_defaultCapacity);

            for (int i = 0; i < _defaultCapacity; i++)
            {
                var bullet = Instantiate(_bulletPrefab);
                bullet.gameObject.SetActive(false);
                _bulletList.Add(bullet);
            }
        }

        private void Clear()
        {
            _bulletList.Clear();
        }

        public Bullet Get(Vector3 pos)
        {
            foreach (var item in _bulletList)
            {
                if (item.gameObject.activeInHierarchy is false)
                {
                    item.transform.position = pos;
                    item.gameObject.SetActive(true);
                    return item;
                }
            }

            var bullet = Instantiate(_bulletPrefab);
            bullet.transform.position = pos;
            _bulletList.Add(bullet);
            return bullet;
        }
    }

    public interface IBulletManager
    {
        Bullet Get(Vector3 pos);
    }
}