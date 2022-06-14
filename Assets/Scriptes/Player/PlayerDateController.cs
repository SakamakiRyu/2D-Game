using UnityEngine;

/// <summary>
/// プレイヤーの各種データを操作するコンポーネント
/// </summary>
public class PlayerDateController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private float _walkingSpeed;
    #endregion

    #region Property
    /// <summary>
    /// 歩行速度を取得
    /// </summary>
    public float GetWalkingSpeed => _walkingSpeed;
    #endregion
}
