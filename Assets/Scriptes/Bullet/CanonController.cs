using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// –C‘ä‚ÌŠÇ—‚ğ‚·‚éƒRƒ“ƒ|[ƒlƒ“ƒg
/// Œ»óA–C‘ä‚Í3‚ÂB
/// </summary>
public class CanonController : MonoBehaviour
{
    #region Define
    /// <summary>
    /// –C‘ä
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
    /// InputSystem‚ÉŒÄ‚Î‚ê‚éˆ—(Fire1)
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
    /// InputSystem‚ÉŒÄ‚Î‚ê‚éˆ—(Fire2)
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
    /// InputSystem‚ÉŒÄ‚Î‚ê‚éˆ—(Fire3)
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
    /// ’e‚ğ”­Ë‚·‚é
    /// </summary>
    /// <param name="CanonIndex">Canon‚ÌIndex</param>
    private void Fire(int CanonIndex)
    {
        // ”­Ë‚·‚é’e‚Ìî•ñ
        var bullet = CanonsArray[CanonIndex];
        // ’e‚Ìƒf[ƒ^‚ğæ“¾
        var date = _bulletsDate.GetBulletDate(bullet.Type, bullet.Size);

        if (date is not null)
        {
            // ’e‚ğ¶¬
            var go = Instantiate(_bulletPrefab, bullet.Muzzle.position, Quaternion.identity).GetComponent<BulletController>();
            // ’e‚ğ”­Ë
            go.Fire(Vector2.right, date.Speed);
        }
    }

    private void OnValidate()
    {

    }
}
