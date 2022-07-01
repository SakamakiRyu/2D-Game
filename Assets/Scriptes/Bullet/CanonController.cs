using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// �C��̊Ǘ�������R���|�[�l���g
/// ����A�C���3�B
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

    private const int MAIN_CANON_INDEX = 0;
    private const int SUB1_CANON_INDEX = 1;
    private const int SUB2_CANON_INDEX = 2;
    #endregion

    #region Field
    [SerializeField]
    private BulletsDate _bulletsDate;

    [SerializeField]
    private BulletController _bulletPrefab;

    [SerializeField]
    private Canon[] CanonsArray;
    #endregion

    /// <summary>
    /// InputSystem�ɌĂ΂�鏈��(Fire1)
    /// </summary>
    /// <param name="context"></param>
    public void OnFire1(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Fire(MAIN_CANON_INDEX);
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
            Fire(SUB1_CANON_INDEX);
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
            Fire(SUB2_CANON_INDEX);
        }
    }

    /// <summary>
    /// �e�𔭎˂���
    /// </summary>
    /// <param name="CanonIndex">Canon��Index</param>
    private void Fire(int CanonIndex)
    {
        // ���˂���e�̏��
        var bullet = CanonsArray[CanonIndex];
        // �e�̃f�[�^���擾
        var date = _bulletsDate.GetBulletDate(bullet.Type, bullet.Size);

        if (date is not null)
        {
            // �e�𐶐�
            var go = Instantiate(_bulletPrefab, bullet.Muzzle.position, Quaternion.identity).GetComponent<BulletController>();
            // �e�𔭎�
            go.Fire(Vector2.right, date.Speed);
        }
    }

    private void OnValidate()
    {

    }
}
