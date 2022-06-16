using UnityEngine;

/// <summary>
/// �v���C���[�̊e��f�[�^�𑀍삷��R���|�[�l���g
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
    /// ���s���x
    /// </summary>
    public float GetWalkingSpeed => _walkingSpeed;

    /// <summary>
    /// �_�b�V�����̑��x
    /// </summary>
    public float GetSprintSpeed => _sprintSpeed;
    #endregion
}
