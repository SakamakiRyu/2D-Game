using UnityEngine;

/// <summary>
/// ’e‚ÌŠî’êƒNƒ‰ƒX
/// </summary>
[RequireComponent(typeof(Rigidbody2D), (typeof(CircleCollider2D)))]
public abstract class BulletBase : MonoBehaviour
{
    [SerializeField]
    protected float _bulletSpeed;

    [SerializeField]
    protected Rigidbody2D _rb2d;

    /// <summary>
    /// ’e‚ğ”­Ë‚·‚é
    /// </summary>
    /// <param name="dir">”­Ë‚Ì•ûŒü</param>
    public abstract void Fire(Vector2 dir);

    /// <summary>
    /// ’e‚ª‚ ‚Á‚½Û‚Ìˆ—
    /// </summary>
    protected abstract void OnHit();

    protected abstract void OnBecameInvisible();

    protected virtual void OnTriggerEnter2D()
    {
        OnHit();
    }
}
