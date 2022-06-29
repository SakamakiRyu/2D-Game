using UnityEngine;

/// <summary>
/// í èÌíe
/// </summary>
public class NormalBullet : BulletBase
{
    private void Start()
    {
        Fire(Vector2.right);
    }

    public override void Fire(Vector2 dir)
    {
        _rb2d.velocity = dir * _bulletSpeed;
    }

    protected override void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    protected override void OnHit()
    {
        Debug.Log("hit");
    }
}
