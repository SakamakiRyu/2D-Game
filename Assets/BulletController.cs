using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// ’e‚ÌŠÇ—‚ğ‚·‚éƒNƒ‰ƒX
/// </summary>
public class BulletController : MonoBehaviour
{
    [SerializeField]
    private GameObject _muzzle;

    private BulletBase[] _Bullets;

    public void OnFire(InputAction.CallbackContext context)
    {

    }
}
