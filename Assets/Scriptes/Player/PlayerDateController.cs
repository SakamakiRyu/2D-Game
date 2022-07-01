using UnityEngine;

/// <summary>
/// プレイヤーの各種データを操作するコンポーネント
/// </summary>
public class PlayerDateController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private float _movingSpeed;
    #endregion

    #region Property
    /// <summary>
    /// 移動速度
    /// </summary>
    public float GetWalkingSpeed => _movingSpeed;
    #endregion
}
