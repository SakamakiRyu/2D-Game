namespace UnityEngine
{
    /// <summary>
    /// RigidBody2D�̊g�����\�b�h�N���X
    /// </summary>
    public static class RigidBody2DExtensions
    {
        /// <summary>
        /// ���x�x�N�g����ݒ肷��
        /// </summary>
        /// <param name="velocity"></param>
        public static void SetVelocity(this Rigidbody2D rb2d, Vector2 velocity)
        {
            rb2d.velocity = velocity;
        }
    }
}
