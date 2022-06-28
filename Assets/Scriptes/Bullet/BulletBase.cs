using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ’e‚ÌŠî’êƒNƒ‰ƒX
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public abstract class BulletBase : MonoBehaviour
{
    [SerializeField]
    protected BulletDate _bulletDate;

    [SerializeField]
    protected Rigidbody2D _rb2d;

    /// <summary>
    /// ’e‚ð”­ŽË‚·‚é
    /// </summary>
    /// <param name="dir">”­ŽË•ûŒü</param>
    public abstract void Fire(Vector2 dir);

    public virtual void SetPosition(Vector3 position)
    {
        this.gameObject.transform.position = position;
    }

    public void ChengeActiveMode(bool active)
    {
        this.gameObject.SetActive(active);
    }

    public abstract void Update();
}
