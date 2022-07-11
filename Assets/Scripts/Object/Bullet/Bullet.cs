using UnityEngine;
using DragonPackage;

namespace UniversWar
{
    /// <summary>
    /// �e�R���|�[�l���g
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        #region Field
        [SerializeField]
        private float _defaultSpeed;

        private Rigidbody2D _rb2d;
        #endregion

        #region Unity Function
        private void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
        }

        private void OnBecameInvisible()
        {
        }
        #endregion

        #region Public Function
        /// <summary>
        /// �e�𔭎˂���
        /// </summary>
        public void Shoot(Vector3 postion, Vector2 direction, float speed)
        {
            this.transform.position = postion;
            var velo = direction * speed;
            _rb2d.SetVelocity(velo);
        }

        /// <summary>
        /// �e����ύX����
        /// </summary>
        public void ChengeSpeed(float speed)
        {
            _defaultSpeed = speed;
        }

        /// <summary>
        /// �e�̏���ݒ肷��
        /// </summary>
        public void SetDate(Vector3 pos, Vector2 direction)
        {
            SetPosition(pos);
            SetVelocuty(direction);
        }

        /// <summary>
        /// �e�̑��x�x�N�g����ݒ肷��
        /// </summary>
        private void SetVelocuty(Vector2 direction)
        {
            var velo = direction * _defaultSpeed;
            _rb2d.SetVelocity(velo);
        }

        /// <summary>
        /// �e�̔��˂�����W��ݒ肷��
        /// </summary>
        private void SetPosition(Vector3 position)
        {
            transform.position = position;
        }
        #endregion
    }
}