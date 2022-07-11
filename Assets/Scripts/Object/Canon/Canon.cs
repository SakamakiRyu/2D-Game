using UnityEngine;
using System.Collections;
using DragonPackage;

namespace UniversWar
{
    /// <summary>
    /// �C��R���|�[�l���g
    /// </summary>
    public sealed class Canon : MonoBehaviour
    {
        #region Field
        [SerializeField]
        private Transform _muzzleTransform;

        [SerializeField]
        private BulletManager _bulletManager; 

        [SerializeField]
        private float _defaultInterval = 0.5f;

        private float _interval = 0f;
        #endregion

        private void Awake()
        {
            _interval = _defaultInterval;
        }

        private void Start()
        {
            RequestFire(Vector2.right);
        }

        /// <summary>
        /// �C���^�[�o����ύX����
        /// </summary>
        /// <param name="interval"></param>
        public void ChengeInterval(float interval)
        {
            _interval = interval;
        }

        /// <summary>
        /// �e�̔��˃��N�G�X�g
        /// </summary>
        public void RequestFire(Vector2 dir)
        {
            StartCoroutine(FireAsync(this.transform, dir));
        }

        /// <summary>
        /// �e�𔭎˂���
        /// </summary>
        private IEnumerator FireAsync(Transform transform, Vector2 dir)
        {
            while (true)
            {
                // �C���^�[�o��
                yield return IEnumeratorExtensions.WaitAsync(_interval);
                // �e�̐���
                var bullet = _bulletManager.GetBullet(transform);
                // �e�̏���ݒ肷��
                bullet.SetDate(_muzzleTransform.position, dir);
                yield return null;
            }
        }
        #region Editor
        #endregion
    }
}