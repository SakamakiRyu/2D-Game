using UnityEngine;

/// <summary>
/// �v���C���[�̊e��f�[�^�𑀍삷��R���|�[�l���g
/// </summary>
public class PlayerDateController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private float _movingSpeed;
    #endregion

    #region Property
    /// <summary>
    /// �ړ����x
    /// </summary>
    public float GetWalkingSpeed => _movingSpeed;
    #endregion
}
