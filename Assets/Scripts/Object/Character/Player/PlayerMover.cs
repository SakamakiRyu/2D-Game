using UnityEngine;
using DragonPackage;

namespace UniversWar
{
    /// <summary>
    /// RigidBody2D�Ńv���C���[�𓮂����R���|�[�l���g
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
        /// Move�����N�G�X�g����
        /// </summary>
        /// <param name="dir">�ړ�����</param>
        public void RequestMove(Vector2 dir)
        {
            Move(dir);
        }

        private void Move(Vector2 dir)
        {
            // ���x�x�N�g�����쐬
            var velo = CreateVelocity(dir);
            // �쐬�������x��ݒ肷��
            _rb2d.SetVelocity(velo);
        }

        /// <summary>
        /// ���x�x�N�g�����쐬����
        /// </summary>
        /// <param name="dir">�����x�N�g��</param>
        /// <returns>���x�x�N�g��</returns>
        private Vector2 CreateVelocity(Vector2 dir)
        {
            return dir * _movingSpeed;
        }
    }
}