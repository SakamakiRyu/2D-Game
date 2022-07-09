using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// 弾コンポーネント
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
        /// 弾の速度ベクトルを設定する
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