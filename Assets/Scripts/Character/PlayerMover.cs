using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// InputSystem�̓��͂ɂ���āA�v���C���[�̑��삷��R���|�[�l���g
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2d = default;

    [SerializeField]
    private float _movingSpeed = default;

    /// <summary>
    /// InputSystem�p�R�[���o�b�N�֐�
    /// </summary>
    /// <param name="context">���͂��ꂽ�����x�N�g��</param>
    public void OnMove(InputAction.CallbackContext context)
    {
        var dir = context.ReadValue<Vector2>();
        var velo = CreateVelocity(dir);
        SetVelocity(velo);
    }

    /// <summary>
    /// ���͂̕����x�N�g�����瑬�x�x�N�g�����쐬����
    /// </summary>
    /// <param name="Direction">�����x�N�g��</param>
    /// <returns>���x�x�N�g��</returns>
    private Vector2 CreateVelocity(Vector2 Direction)
    {
        return Direction * _movingSpeed;
    }

    /// <summary>
    /// ���x�x�N�g����ݒ肷��
    /// </summary>
    private void SetVelocity(Vector2 velo)
    {
        if (_rb2d)
        {
            _rb2d.velocity = velo;
        }
    }
}