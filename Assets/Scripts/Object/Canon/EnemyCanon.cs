using DragonPackage;
using System.Collections;
using UnityEngine;

namespace UniversWar
{
    public class EnemyCanon : CanonBase
    {
        public Player Player { get; set; }

        public EnemyCanonDate CanonDate { get; set; }

        // �e�����邩
        private bool _hasBullet { get; set; } = true;

        private void Update()
        {
            IsFired();
        }

        /// <summary>
        /// �U�����邩
        /// </summary>
        /// <returns></returns>
        private bool IsFired()
        {
            // �e�����������牽�����Ȃ�
            if (_hasBullet is false)
                return false;

            // ���g��y���W
            var currentY = this.transform.position.y;
            // �Ώۂ̍��W
            var targetPosY = Player.transform.position.y;
            // ��_�̂����W����
            var def = Mathf.Abs(targetPosY - currentY);
            // �U�����邩
            var isFire = def < CanonDate.Range;

            if (isFire is false)
            {
                return false;
            }

            Fire();
            return true;
        }

        /// <summary>
        /// �U���̏���
        /// </summary>
        protected override void Fire()
        {
            if (_hasBullet is false) return;

            if (ServiceLocator<IBulletManager>.IsValid)
            {
                var bullet = ServiceLocator<IBulletManager>.Instance.Get(_muzzleTransform.position);
                bullet.Shoot(Vector2.left, CanonDate.BulletSpeed);
                _hasBullet = false;
                // �e�̏[�U
                StartCoroutine(ChergeBulletAsync());
            }
        }

        /// <summary>
        /// �e�̏[�U����
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
