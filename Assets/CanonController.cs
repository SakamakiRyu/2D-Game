using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 砲台の操作をするコンポーネント
/// </summary>
public class CanonController : MonoBehaviour
{
    [SerializeField]
    private Transform _muzzleTrasnform = default;

    [SerializeField]
    private BulletController _bullet = default;

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    /// <summary>
    /// InputSystem用コールバック関数
    /// </summary>
    /// <param name="context"></param>
    public void OnFire(InputAction.CallbackContext context)
    {
        // キーが押された時
        if (context.started)
        {
            Fire();
        }
    }

    /// <summary>
    /// 弾を発射する
    /// </summary>
    private void Fire()
    {
        var bullet = CreateBullet();
    }

    private BulletController CreateBullet()
    {
        return null;
    }
}