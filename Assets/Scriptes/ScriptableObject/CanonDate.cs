using System;
using UnityEngine;

/// <summary>
/// 砲台の初期データを管理するスクリプタブルオブジェクト
/// </summary>
[CreateAssetMenu(fileName = "Create Canon Date", menuName = "Canon Date")]
public class CanonDate : ScriptableObject
{
    #region Define
    /// <summary>
    /// 砲台
    /// </summary>
    [Serializable]
    public class Canon
    {
        public string Name;
        public BulletDate.Type Type;
        public BulletDate.Size Size;
    }

    public Canon DefaultDates;
    #endregion
}
