using UnityEngine;

/// <summary>
/// キャラクターの基底クラス
/// </summary>
public abstract class CharacterBase : MonoBehaviour
{
    /// <summary>
    /// 死んでいるか
    /// </summary>
    public bool IsDead => CurrentHP <= 0;

    /// <summary>
    /// 現在のHP
    /// </summary>
    public int CurrentHP { get; protected set; } = default;

    /// <summary>
    /// 移動する
    /// </summary>
    protected abstract void Move(float movingSpeed);
}
