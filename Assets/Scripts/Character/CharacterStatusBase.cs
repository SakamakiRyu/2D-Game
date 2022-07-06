using UnityEngine;

/// <summary>
/// キャラクターの基底クラス
/// </summary>
public abstract class CharacterStatusBase : MonoBehaviour
{
    /// <summary>
    /// 死んでいるか
    /// </summary>
    public bool IsDead => CurrentHP <= 0;

    /// <summary>
    /// 現在のHP
    /// </summary>
    public int CurrentHP { get; protected set; } = default;
}
