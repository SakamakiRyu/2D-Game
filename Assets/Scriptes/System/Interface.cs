/// <summary>
/// 弾が当たるようになる
/// </summary>
interface IBulletHitabel
{
    /// <summary>
    /// 弾が当たった時に呼ばれる処理
    /// </summary>
    void OnHit();
}