using UnityEngine;

namespace DragonPackage
{
    /// <summary>
    /// RigidBody2Dの拡張クラス
    /// </summary>
    public static class RigidBody2DExtensions
    {
        /// <summary>
        /// 速度ベクトルを設定する
        /// </summary>
        /// <param name="velocity"></param>
        public static void SetVelocity(this Rigidbody2D rb2d, Vector2 velocity)
        {
            rb2d.velocity = velocity;
        }
    }
}

