using DragonPackage;
using UnityEngine;

namespace UniversWar
{
    public class EnemyCanon : CanonBase
    {
        [SerializeField]
        private PlayerMover _playerMover;

        [SerializeField]
        private float _different;

        private void Update()
        {
            if (FindPlayer())
            {
            }
        }

        private bool FindPlayer()
        {
            var currentY = this.transform.position.y;
            var y = _playerMover.transform.position.y;
            var minY = y - _different;
            var maxY = y + _different;

            var result = currentY > minY && currentY < maxY;

            if (result)
            {
                Fire();
                return true;
            }
            return false;
        }

        protected override void Fire()
        {
            if (ServiceLocator<IBulletManager>.IsValid)
            {
                var bullet = ServiceLocator<IBulletManager>.Instance.Get(_muzzleTransform.position);
                bullet.Shoot(Vector2.left, _bulletSpeed);
            }
        }
    }
}
