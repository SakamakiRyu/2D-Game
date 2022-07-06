using UnityEngine;

/// <summary>
/// �L�����N�^�[�̊��N���X
/// </summary>
public abstract class CharacterBase : MonoBehaviour
{
    /// <summary>
    /// ����ł��邩
    /// </summary>
    public bool IsDead => CurrentHP <= 0;

    /// <summary>
    /// ���݂�HP
    /// </summary>
    public int CurrentHP { get; protected set; } = default;

    /// <summary>
    /// �ړ�����
    /// </summary>
    protected abstract void Move(float movingSpeed);
}
