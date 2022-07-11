using UnityEngine;
using DragonPackage;

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
        public void Shoot(Vector3 postion, Vector3 direction, float speed)
        {
            _rb2d.SetVelocity()
        }

        /// <summary>
        /// 弾速を変更する
        /// </summary>
        public void ChengeSpeed(float speed)
        {
            _defaultSpeed = speed;
        }

        /// <summary>
        /// 弾の情報を設定する
        /// </summary>
        public void SetDate(Vector3 pos, Vector2 direction)
        {
            SetPosition(pos);
            SetDirection(direction);
        }

        /// <summary>
        /// 弾の速度ベクトルを設定する
        /// </summary>
        private void SetDirection(Vector2 direction)
        {
            var velo = direction * _defaultSpeed;
            _rb2d.SetVelocity(velo);
        }

        /// <summary>
        /// 弾の発射する座標を設定する
        /// </summary>
        private void SetPosition(Vector3 position)
        {
            transform.position = position;
        }
        #endregion
    }
}