using UnityEngine;
using UnityEngine.InputSystem;
using DragonPackage;
using System.Collections;
using System;

namespace UniversWar
{
    public class PlayerCanon : CanonBase
    {
        [SerializeField]
        private float _bulletSpeed;

        [SerializeField]
        private int _maxBulletAmount;

        private int CurrentAmount{ get; set; }

        private void Start()
        {
            CurrentAmount = _maxBulletAmount;
        }

        // コールバック
        public void OnFire(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                Fire();
            }
        }

        // 射撃
        protected override void Fire()
        {
            if (CurrentAmount <= 0)
            {
                ReloadBullet();
            }

            if (ServiceLocator<IBulletManager>.IsValid)
            {
                var bullet = ServiceLocator<IBulletManager>.Instance.Get(_muzzleTransform.position);
                bullet.Shoot(Vector2.right, _bulletSpeed);
                CurrentAmount--;
            }
        }

        // 弾の装填
        private void ReloadBullet()
        {
            CurrentAmount = _maxBulletAmount;
        }
    }
}
