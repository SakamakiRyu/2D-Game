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

        // �e�����邩
        private bool _hasBullet { get; set; } = true;

        private void Update()
        {
            IsFired();
        }

        /// <summary>
        /// �U�����邩
        /// </summary>
        private bool IsFired()
        {
            // �e����������orPlayer���Q�Əo���Ȃ������牽�����Ȃ�
            if (_hasBullet is false || _player is null)
                return false;

            // ���g��y���W
            var currentY = this.transform.position.y;
            // �Ώۂ̍��W
            var targetPosY = _player.transform.position.y;
            // ��_�̂����W����
            var distance = Mathf.Abs(targetPosY - currentY);
            // �U�����邩
            var isFire = distance < _canonDate.Range;

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
                bullet.Shoot(Vector2.left, _canonDate.BulletSpeed);
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
