using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// �C��̊Ǘ�������R���|�[�l���g
/// </summary>
public class CanonController : MonoBehaviour
{
    [SerializeField]
    private Transform _mainMuzzleTransform;

    [SerializeField]
    private BulletBase _bullet;

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            MainFire(_bullet);
        }
    }

    public void MainFire(BulletBase bullet)
    {
        Instantiate(bullet, _mainMuzzleTransform.position, Quaternion.identity);
    }
}
