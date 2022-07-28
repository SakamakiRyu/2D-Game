using DragonPackage;
using System.Collections;
using UnityEngine;

namespace UniversWar
{
    public class EnemyCanon : CanonBase
    {
        [SerializeField]
        private PlayerMover _playerMover;

        [SerializeField]
        private EnemyCanonDate _canonDate;

        // ’e‚ª‚ ‚é‚©
        private bool _hasBullet { get; set; } = true;

        private void Update()
        {
            IsFired();
        }

        /// <summary>
        /// UŒ‚‚·‚é‚©
        /// </summary>
        /// <returns></returns>
        private bool IsFired()
        {
            // ’e‚ª–³‚©‚Á‚½‚ç‰½‚à‚µ‚È‚¢
            if (_hasBullet is false)
                return false;

            // ©g‚ÌyÀ•W
            var currentY = this.transform.position.y;
            // ‘ÎÛ‚ÌÀ•W
            var targetPosY = _playerMover.transform.position.y;
            // “ñ“_‚Ì‚™À•W‹——£
            var def = Mathf.Abs(targetPosY - currentY);
            // UŒ‚‚·‚é‚©
            var isFire = def < _canonDate.Range;

            if (isFire is false)
            {
                return false;
            }

            Fire();
            return true;
        }

        /// <summary>
        /// UŒ‚‚Ìˆ—
        /// </summary>
        protected override void Fire()
        {
            if (_hasBullet is false) return;

            if (ServiceLocator<IBulletManager>.IsValid)
            {
                var bullet = ServiceLocator<IBulletManager>.Instance.Get(_muzzleTransform.position);
                bullet.Shoot(Vector2.left, _canonDate.BulletSpeed);
                _hasBullet = false;
                // ’e‚Ì[“U
                StartCoroutine(ChergeBulletAsync());
            }
        }

        /// <summary>
        /// ’e‚Ì[“Uˆ—
        /// </summary>
        private IEnumerator ChergeBulletAsync()
        {
            var timer = 0f;
            while (timer < _canonDate.ChargeTime)
            {
                timer += Time.deltaTime;
                yield return null;
            }
            _hasBullet = true;
            yield return null;
        }
    }
}
