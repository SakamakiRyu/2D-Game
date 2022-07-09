using UnityEngine;

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
        private float _speed;

        [SerializeField]
        private Rigidbody2D _rb2d;
        #endregion

        #region Unity Function
        #endregion

        #region Public Function
        /// <summary>
        /// �e�̑��x�x�N�g����ݒ肷��
        /// </summary>
        public void SetDirection(Vector2 direction)
        {
            if (_rb2d)
            {
                var velo = direction * _speed;
                _rb2d.SetVelocity(velo);
            }
        }
        #endregion
    }
}