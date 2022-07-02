using System;
using UnityEngine;

/// <summary>
/// ’e‚Ì•¨—‹““®‚ğŠÇ—‚·‚éƒNƒ‰ƒX
/// </summary>
[RequireComponent(typeof(Rigidbody2D), (typeof(CircleCollider2D)))]
public class BulletController : MonoBehaviour
{
    #region Define
    #endregion

    #region Field
    [SerializeField]
    private Rigidbody2D _rb2d;

    [SerializeField]
    private CircleCollider2D _collider;

    /// <summary>’e‚Ìî•ñ</summary>
    private BulletsDate.Bullet _bulletDate;
    #endregion

    #region Unity Fucntion
    private void Start()
    {
        SetVelocity(_bulletDate.Speed);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
    }

    private void OnValidate()
    {
        if (_rb2d is null)
        {
            TryGetComponent(out _rb2d);
            _rb2d.gravityScale = 0f;
        }

        if (_collider is null)
        {
            TryGetComponent(out _collider);
            if (_collider)
            {
                _collider.isTrigger = true;
            }
        }
    }
    #endregion

    #region Public Fucntion
    /// <summary>
    /// ’e‚Ìî•ñ‚ğİ’è‚·‚é
    /// </summary>
    public void SetBulletDate(BulletsDate.Bullet bulletDate)
    {
        _bulletDate = bulletDate;
    }
    #endregion

    #region Private Function
    /// <summary>
    /// ’e‚Ì‘¬“x‚ğİ’è‚·‚é
    /// </summary>
    private void SetVelocity(float speed)
    {
        _rb2d.velocity = Vector2.right * speed;
    }
    #endregion
}
