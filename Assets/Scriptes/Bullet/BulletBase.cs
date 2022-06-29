using UnityEngine;

/// <summary>
/// �e�̊��N���X
/// </summary>
[RequireComponent(typeof(Rigidbody2D), (typeof(CircleCollider2D)))]
public abstract class BulletBase : MonoBehaviour
{
    [SerializeField]
    protected float _bulletSpeed;

    [SerializeField]
    protected Rigidbody2D _rb2d;

    /// <summary>
    /// �e�𔭎˂���
    /// </summary>
    /// <param name="dir">���˂̕���</param>
    public abstract void Fire(Vector2 dir);

    /// <summary>
    /// �e���������ۂ̏���
    /// </summary>
    protected abstract void OnHit();

    protected abstract void OnBecameInvisible();

    protected virtual void OnTriggerEnter2D()
    {
        OnHit();
    }
}
