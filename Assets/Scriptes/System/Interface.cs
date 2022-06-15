/// <summary>
/// 入手できるようになる
/// </summary>
internal interface IGetable
{
    /// <summary>
    /// 入手した時の処理
    /// </summary>
    public void OnGet();
}