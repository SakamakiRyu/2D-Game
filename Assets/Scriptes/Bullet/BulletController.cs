using System;
using UnityEngine;

/// <summary>
/// ’e‚Ì•¨—‹““®‚ğŠÇ—‚·‚éƒNƒ‰ƒX
/// </summary>
[RequireComponent(typeof(Rigidbody2D), (typeof(CircleCollider2D)))]
public class BulletController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private Rigidbody2D _rb2d;

    [SerializeField]
    private CircleCollider2D _collider;
    #endregion

    #region Unity Fucntion
    private void Start()
    {
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
        }
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
    /// ’e‚ª”­Ë‚³‚ê‚½‚Ìˆ—
    /// </summary>
    /// <param name="dir">”­Ë‚Ì•ûŒü</param>
    public void Fire(Vector2 dir, float speed)
    {
        _rb2d.velocity = dir * speed;
    }
    #endregion
}
