using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// �C��̊Ǘ�������R���|�[�l���g
/// </summary>
public class CanonController : MonoBehaviour
{
    #region Define
    /// <summary>
    /// �C��
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
