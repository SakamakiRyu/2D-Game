using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾のデータを管理するスクリプタブルオブジェクト
/// </summary>
[CreateAssetMenu(fileName = "Create bullets date", menuName = "BulletsDate")]
public class BulletsDate : ScriptableObject
{
    #region Define
    /// <summary>
    /// 弾の種類
    /// </summary>
    public enum Type
    {
        None = -1,
        Normal,
    }

    /// <summary>
    /// 弾のサイズ
    /// </summary>
    public enum Size
    {
        None = -1,
        S,
        M,
        L
    }

    /// <summary>
    /// 弾のデータ
    /// </summary>
    [System.Serializable]
    public class Bullet
    {
        public string Name;
        public Type Type;
        public Size Size;
        public float Speed;
        public int Power;
    }
    #endregion

    /// <summary>
    /// 弾のリスト
    /// </summary>
    public List<Bullet> BulletsList;

    /// <summary>
    /// 弾のデータを取得
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public Bullet GetBulletDate(Type type, Size size)
    {
        return BulletsList[(int)type];
    }

    public string GetBulletName(Type type)
    {
        return BulletsList[(int)type].Name;
    }

    public float GetBulletSpeed(Type type)
    {
        return BulletsList[(int)type].Speed;
    }

    public int GetBulletPower(Type type)
    {
        return BulletsList[((int)type)].Power;
    }
}
