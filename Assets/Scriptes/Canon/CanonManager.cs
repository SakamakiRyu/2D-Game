using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 砲台の管理をするコンポーネント
/// 現状、砲台は3つ。
/// </summary>
public class CanonManager : MonoBehaviour
{
    #region Define
    #endregion

    #region Field
    [SerializeField]
    private BulletDate _bulletsDate;

    [SerializeField]
    private CanonDate _canonDefaultDate;

    [SerializeField]
    private BulletController _bulletPrefab;

    [SerializeField]
    private CanonController _mainCanon;

    [SerializeField]
    private CanonController _sub1Canon;

    [SerializeField]
    private CanonController _sub2Canon;
    #endregion

    #region Input System Callbacks
    /// <summary>
    /// InputSystemに呼ばれる処理(Fire1)
    /// </summary>
    /// <param name="context"></param>
    public void OnFire1(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
    }

    /// <summary>
    /// InputSystemに呼ばれる処理(Fire2)
    /// </summary>
    /// <param name="context"></param>
    public void OnFire2(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
    }

    /// <summary>
    /// InputSystemに呼ばれる処理(Fire3)
    /// </summary>
    /// <param name="context"></param>
    public void OnFire3(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
    }
    #endregion

    private void OnValidate()
    {

    }
}
