using System;
using UnityEngine;

/// <summary>
/// 砲台の初期データを管理するスクリプタブルオブジェクト
/// </summary>
[CreateAssetMenu(fileName = "Create Canon Date", menuName = "Canon Date")]
public class CanonDefaultDate : ScriptableObject
{
    #region Define
    /// <summary>
    /// 砲台
    /// </summary>
    [Serializable]
    public class Canon
    {
        public string Name;
        public BulletsDate.Type Type;
        public BulletsDate.Size Size;
    }

    /// <summary>
    /// スゥグォイナァ！オマエタチィ！
    /// </summary>
    public Canon[] DefaultDates;
    #endregion
}
