using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 砲台コンポーネント
/// </summary>
public class Canon : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {

        }
    }

    public void Fire(GameObject bulletObject,Vector2 velocity)
    {

    }
}
