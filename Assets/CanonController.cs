using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CanonController : MonoBehaviour
{
    [SerializeField]
    private Transform _mainMuzzleTransform;

    [SerializeField]
    private Transform _subMuzzleTrasnformFirst;

    [SerializeField]
    private Transform _subMuzzleTrasnformSecond;

    [SerializeField]
    private GameObject _bullet;

    public void OnFire(InputAction.CallbackContext context)
    {
        MainFire();
    }

    public void MainFire()
    {
        Instantiate(_bullet, _mainMuzzleTransform.position, Quaternion.identity);
    }

    public void SubFire(BulletBase bullet)
    {

    }
}
