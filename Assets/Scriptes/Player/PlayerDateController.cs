using UnityEngine;

/// <summary>
/// �v���C���[�̊e��f�[�^�𑀍삷��R���|�[�l���g
/// </summary>
public class PlayerDateController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private float _walkingSpeed;
    #endregion

    #region Property
    /// <summary>
    /// ���s���x���擾
    /// </summary>
    public float GetWalkingSpeed => _walkingSpeed;
    #endregion
}
