using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniversWar;


public class BulletManager : MonoBehaviour
{
    [SerializeField]
    private BulletPool _bulletPool;

    private void Awake()
    {
    }

    public Bullet GetBullet(Transform Transform)
    {
        return _bulletPool.GetBullet(Transform.position, Quaternion.identity);
    }
}
