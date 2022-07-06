using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// InputSystemの入力によって、プレイヤーの操作するコンポーネント
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2d = default;

    [SerializeField]
    private float _movingSpeed = default;

    /// <summary>
    /// InputSystem用コールバック関数
    /// </summary>
    /// <param name="context">入力された方向ベクトル</param>
    public void OnMove(InputAction.CallbackContext context)
    {
        var dir = context.ReadValue<Vector2>();
        var velo = CreateVelocity(dir);
        SetVelocity(velo);
    }

    /// <summary>
    /// 入力の方向ベクトルから速度ベクトルを作成する
    /// </summary>
    /// <param name="Direction">方向ベクトル</param>
    /// <returns>速度ベクトル</returns>
    private Vector2 CreateVelocity(Vector2 Direction)
    {
        return Direction * _movingSpeed;
    }

    /// <summary>
    /// 速度ベクトルを設定する
    /// </summary>
    private void SetVelocity(Vector2 velo)
    {
        if (_rb2d)
        {
            _rb2d.velocity = velo;
        }
    }
}