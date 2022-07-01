using UnityEngine;

/// <summary>
/// ’e‚ÌŠî’êƒNƒ‰ƒX
/// </summary>
[RequireComponent(typeof(Rigidbody2D), (typeof(CircleCollider2D)))]
public abstract class BulletBase : MonoBehaviour
{
    #region Field
    [SerializeField]
    protected BulletDate.Type _type;

    [SerializeField]
    protected BulletDate _bulletDate;

    [SerializeField]
    protected Rigidbody2D _rb2d;
    #endregion

    #region Abstract Fucntion
    /// <summary>
    /// ’e‚ª”­Ë‚³‚ê‚½‚Ìˆ—
    /// </summary>
    /// <param name="dir">”­Ë‚Ì•ûŒü</param>
    public abstract void Fired(Vector2 dir);

    /// <summary>
    /// ’e‚ª‚ ‚½‚Á‚½Û‚Ìˆ—
    /// </summary>
    protected abstract void OnHit();
    #endregion

    #region Unity Fucntion
    protected virtual void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            OnHit();
        }
    }

    private void OnValidate()
    {
        if (_rb2d is null)
        {
            TryGetComponent(out _rb2d);
        }
    }
    #endregion
}
