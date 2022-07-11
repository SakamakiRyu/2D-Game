using UnityEngine;
using DragonPackage;

namespace UniversWar
{
    /// <summary>
    /// RigidBody2Dでプレイヤーを動かすコンポーネント
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class PlayerMover : MonoBehaviour
    {
        #region Field
        [SerializeField]
        private Rigidbody2D _rb2d;

        [SerializeField]
        private float _movingSpeed;
        #endregion

        #region Property
        #endregion

        #region Unity Function
        private void OnValidate()
        {
            if (_rb2d)
            {
                _rb2d.gravityScale = 0f;
            }
        }
        #endregion

        /// <summary>
        /// Moveをリクエストする
        /// </summary>
        /// <param name="dir">移動方向</param>
        public void RequestMove(Vector2 dir)
        {
            Move(dir);
        }

        private void Move(Vector2 dir)
        {
            // 速度ベクトルを作成
            var velo = CreateVelocity(dir);
            // 作成した速度を設定する
            _rb2d.SetVelocity(velo);
        }

        /// <summary>
        /// 速度ベクトルを作成する
        /// </summary>
        /// <param name="dir">方向ベクトル</param>
        /// <returns>速度ベクトル</returns>
        private Vector2 CreateVelocity(Vector2 dir)
        {
            return dir * _movingSpeed;
        }
    }
}