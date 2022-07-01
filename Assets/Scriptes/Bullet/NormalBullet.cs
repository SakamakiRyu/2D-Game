using UnityEngine;

/// <summary>
/// í èÌíe
/// </summary>
public class NormalBullet : BulletBase
{
    private void Start()
    {
        Fired(Vector2.right);
    }

    public override void Fired(Vector2 dir)
    {
        var speed = _bulletDate.GetBulletSpeed(_type);
        _rb2d.velocity = dir * speed;
    }

    protected override void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    protected override void OnHit()
    {
        Destroy(this.gameObject);
    }
}
