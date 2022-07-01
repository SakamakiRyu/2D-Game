using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 砲台の管理をするコンポーネント
/// </summary>
public class CanonController : MonoBehaviour
{
    #region Define
    /// <summary>
    /// 砲台
    /// </summary>
    [System.Serializable]
    public class Canon
    {
        public string Name;
        public BulletsDate.Type Type;
        public BulletsDate.Size Size;
        public Transform Muzzle;
    }
    #endregion

    #region Field
    [SerializeField]
    private BulletsDate _bulletsDate;

    [SerializeField]
    private BulletController _bulletPrefab;

    [SerializeField]
    private Canon[] CanonsArray;
    #endregion

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {

        }
    }

    private void OnValidate()
    {

    }
}
