using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// �C��̑��������R���|�[�l���g
/// </summary>
public class CanonController : MonoBehaviour
{
    [SerializeField]
    private Transform _muzzleTrasnform = default;

    [SerializeField]
    private BulletController _bullet = default;

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    /// <summary>
    /// InputSystem�p�R�[���o�b�N�֐�
    /// </summary>
    /// <param name="context"></param>
    public void OnFire(InputAction.CallbackContext context)
    {
        // �L�[�������ꂽ��
        if (context.started)
        {
            Fire();
        }
    }

    /// <summary>
    /// �e�𔭎˂���
    /// </summary>
    private void Fire()
    {
        var bullet = CreateBullet();
    }

    private BulletController CreateBullet()
    {
        return null;
    }
}