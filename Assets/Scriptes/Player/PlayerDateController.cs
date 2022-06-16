using UnityEngine;

/// <summary>
/// プレイヤーの各種データを操作するコンポーネント
/// </summary>
public class PlayerDateController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private float _walkingSpeed;

    [SerializeField]
    private float _sprintSpeed;
    #endregion

    #region Property
    /// <summary>
    /// 歩行速度
    /// </summary>
    public float GetWalkingSpeed => _walkingSpeed;

    /// <summary>
    /// ダッシュ時の速度
    /// </summary>
    public float GetSprintSpeed => _sprintSpeed;
    #endregion
}
