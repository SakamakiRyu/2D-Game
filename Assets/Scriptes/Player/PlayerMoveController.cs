using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// �v���C���[�̕��������𑀍삷��R���|�[�l���g
/// </summary>
[RequireComponent(typeof(Rigidbody2D), typeof(PlayerDateController))]
public class PlayerMoveController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private PlayerDateController _date;

    [SerializeField]
    private Rigidbody2D _rb;
    #endregion

    #region Unity Function
    private void Start()
    {
    }

    private void Update()
    {
    }
    #endregion

    #region Public Function
    /// <summary>
    /// InputSystem�ɂ����Move�̓��͂����ꂽ���ɌĂ΂�鏈��
    /// </summary>
    public void OnMove(InputAction.CallbackContext context)
    {
        var v2 = context.ReadValue<Vector2>();
        var dir = Vector2.right * v2.x + Vector2.up * v2.y;
        var velo = dir * _date.GetWalkingSpeed;
        _rb.velocity = velo;
    }
    #endregion

    #region Private Field
    #endregion
}
