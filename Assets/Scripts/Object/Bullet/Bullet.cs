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

        [SerializeField]
        private Rigidbody2D _rb2d;
        #endregion

        #region Unity Function
        private void OnBecameInvisible()
        {
            Destroy(this.gameObject);
        }
        #endregion

        #region Public Function
        /// <summary>
        /// �e����ύX����
        /// </summary>
        public void ChengeSpeed(float speed)
        {
            _defaultSpeed = speed;
        }

        /// <summary>
        /// �e�𐶐�����
        /// </summary>
        public Bullet CreateBullet(Transform parent)
        {
            var bullet = Instantiate(this.gameObject, parent).GetComponent<Bullet>();
            bullet.transform.parent = parent;
            return bullet;
        }

        /// <summary>
        /// �e�̏���ݒ肷��
        /// </summary>
        public void SetDate(Vector3 pos, Vector2 direction)
        {
            SetPosition(pos);
            SetDirection(direction);
        }

        /// <summary>
        /// �e�̑��x�x�N�g����ݒ肷��
        /// </summary>
        private void SetDirection(Vector2 direction)
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