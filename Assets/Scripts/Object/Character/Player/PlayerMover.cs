using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// RigidBody�Ńv���C���[�𓮂����R���|�[�l���g
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
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
    #endregion

    /// <summary>
    /// InputSystem�p�R�[���o�b�N�֐�
    /// </summary>
    /// <param name="context"></param>
    public void OnMove(InputAction.CallbackContext context)
    {
        // ���͂��ꂽ�����x�N�g��
        var dir = context.ReadValue<Vector2>();
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

    /// <summary>
    /// ���x�x�N�g����ݒ肷��(�����I�ɓ���)
    /// </summary>
    /// <param name="velocity">���x�x�N�g��</param>
    private void SetVelocity(Vector2 velocity)
    {
        if (_rb2d)
        {
            _rb2d.velocity = velocity;
        }
    }

    private void OnValidate()
    {
        if (_rb2d)
        {
            _rb2d.gravityScale = 0f;
        }
    }
}
