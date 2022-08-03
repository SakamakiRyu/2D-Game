using DragonPackage;
using System.Collections;
using UnityEngine;

namespace UniversWar
{
    public class EnemyCanon : CanonBase
    {
        [SerializeField]
        private EnemyCanonDate _canonDate;

        [SerializeField]
        public Player _player;

        // ’e‚ª‚ ‚é‚©
        private bool _hasBullet { get; set; } = true;

        private void Update()
        {
            IsFired();
        }

        /// <summary>
        /// UŒ‚‚·‚é‚©
        /// </summary>
        private bool IsFired()
        {
            // ’e‚ª–³‚©‚Á‚½orPlayer‚ªQÆo—ˆ‚È‚©‚Á‚½‚ç‰½‚à‚µ‚È‚¢
            if (_hasBullet is false || _player is null)
                return false;

            // ©g‚ÌyÀ•W
            var currentY = this.transform.position.y;
            // ‘ÎÛ‚ÌÀ•W
            var targetPosY = _player.transform.position.y;
            // “ñ“_‚Ì‚™À•W‹——£
            var distance = Mathf.Abs(targetPosY - currentY);
            // UŒ‚‚·‚é‚©
            var isFire = distance < _canonDate.Range;

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
