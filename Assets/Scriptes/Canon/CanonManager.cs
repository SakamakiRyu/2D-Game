using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// �C��̊Ǘ�������R���|�[�l���g
/// ����A�C���3�B
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
    /// InputSystem�ɌĂ΂�鏈��(Fire1)
    /// </summary>
    /// <param name="context"></param>
    public void OnFire1(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
    }

    /// <summary>
    /// InputSystem�ɌĂ΂�鏈��(Fire2)
    /// </summary>
    /// <param name="context"></param>
    public void OnFire2(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
    }

    /// <summary>
    /// InputSystem�ɌĂ΂�鏈��(Fire3)
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
