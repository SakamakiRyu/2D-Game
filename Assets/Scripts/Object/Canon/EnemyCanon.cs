using DragonPackage;
using System.Collections;
using UnityEngine;

namespace UniversWar
{
    public class EnemyCanon : CanonBase
    {
        public Player Player { get; set; }

        public EnemyCanonDate CanonDate { get; set; }

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
            var targetPosY = Player.transform.position.y;
            // “ñ“_‚Ì‚™À•W‹——£
            var def = Mathf.Abs(targetPosY - currentY);
            // UŒ‚‚·‚é‚©
            var isFire = def < CanonDate.Range;

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
                bullet.Shoot(Vector2.left, CanonDate.BulletSpeed);
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
            while (timer < CanonDate.ChargeTime)
            {
                timer += Time.deltaTime;
                yield return null;
            }
            _hasBullet = true;
            yield return null;
        }
    }
}
