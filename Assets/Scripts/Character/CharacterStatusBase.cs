using UnityEngine;

/// <summary>
/// �L�����N�^�[�̊��N���X
/// </summary>
public abstract class CharacterStatusBase : MonoBehaviour
{
    /// <summary>
    /// ����ł��邩
    /// </summary>
    public bool IsDead => CurrentHP <= 0;

    /// <summary>
    /// ���݂�HP
    /// </summary>
    public int CurrentHP { get; protected set; } = default;
}
