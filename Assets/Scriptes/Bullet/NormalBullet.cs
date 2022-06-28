using UnityEngine;

/// <summary>
/// í èÌíe
/// </summary>
public class NormalBullet : BulletBase
{
    public override void Update()
    {
        Fire(Vector2.right);
    }

    public override void Fire(Vector2 dir)
    {
        _rb2d.velocity = dir * _bulletDate._speed;
    }
}
