using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// RigidBody2Dでプレイヤーを動かすコンポーネント
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
    private void OnValidate()
    {
        if (_rb2d)
        {
            _rb2d.gravityScale = 0f;
        }
    }
    #endregion

    /// <summary>
    /// InputSystem用コールバック関数
    /// </summary>
    /// <param name="context"></param>
    public void OnMove(InputAction.CallbackContext context)
    {
        // 入力された方向ベクトル
        var dir = context.ReadValue<Vector2>();
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
