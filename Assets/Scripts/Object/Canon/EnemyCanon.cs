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

        // 弾があるか
        private bool _hasBullet { get; set; } = true;

        private void Update()
        {
            IsFired();
        }

        /// <summary>
        /// 攻撃するか
        /// </summary>
        /// <returns></returns>
        private bool IsFired()
        {
            // 弾が無かったら何もしない
            if (_hasBullet is false)
                return false;

            // 自身のy座標
            var currentY = this.transform.position.y;
            // 対象の座標
            var targetPosY = _playerMover.transform.position.y;
            // 二点のｙ座標距離
            var def = Mathf.Abs(targetPosY - currentY);
            // 攻撃するか
            var isFire = def < _canonDate.Range;

            if (isFire is false)
            {
                return false;
            }

            Fire();
            return true;
        }

        /// <summary>
        /// 攻撃の処理
        /// </summary>
        protected override void Fire()
        {
            if (_hasBullet is false) return;

            if (ServiceLocator<IBulletManager>.IsValid)
            {
                var bullet = ServiceLocator<IBulletManager>.Instance.Get(_muzzleTransform.position);
                bullet.Shoot(Vector2.left, _canonDate.BulletSpeed);
                _hasBullet = false;
                // 弾の充填
                StartCoroutine(ChergeBulletAsync());
            }
        }

        /// <summary>
        /// 弾の充填処理
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
