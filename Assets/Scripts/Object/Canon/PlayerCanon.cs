using UnityEngine;
using UnityEngine.InputSystem;
using DragonPackage;

namespace UniversWar
{
    public class PlayerCanon : CanonBase
    {
        [SerializeField]
        private float _bulletSpeed;

        public void OnFire(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                Fire();
            }
        }

        protected override void Fire()
        {
            if (ServiceLocator<IBulletManager>.IsValid)
            {
                var bullet = ServiceLocator<IBulletManager>.Instance.Get(_muzzleTransform.position);
                bullet.Shoot(Vector2.right, _bulletSpeed);
            }
        }
    }
}
