using UnityEngine;

/// <summary>
/// �v���C���[���B�e����J�����̑���R���|�[�l���g
/// </summary>
public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private PlayerMoveController _followTarget;

    [SerializeField]
    private float _maxOrthographicSize;

    [SerializeField]
    private float _minOrthographicSize;

    [SerializeField]
    private float _chengeValue;

    // �J������Z���W�B
    private const float CAM_POS_Z = -10f;

    private void Start()
    {
        SyncTransform(_followTarget.transform.position);
    }

    private void Update()
    {
        SyncTransform(_followTarget.transform.position);

        if (CheckMouseWheelInput())
        {
            OnChengedMouseWheelValue();
        }
    }

    /// <summary>
    /// �^�[�Q�b�g�ƃ|�W�V�����𓯊�����
    /// </summary>
    private void SyncTransform(Vector3 target)
    {
        var pos = target;
        pos.z = CAM_POS_Z;
        _mainCamera.transform.position = pos;
    }

    /// <summary>
    /// �}�E�X�z�C�[���̓��͂�����Ă��邩
    /// </summary>
    private bool CheckMouseWheelInput()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// �}�E�X�z�C�[���̓��͂����ꂽ���ɌĂ΂�鏈��
    /// </summary>
    private void OnChengedMouseWheelValue()
    {
        // �}�E�X�z�C�[���̓���
        var inputValue = Input.mouseScrollDelta.y;
        // �l�̕ω���
        var chengeValue = _chengeValue;
        // �J�����̕`��T�C�Y
        var afterCamSize = _mainCamera.orthographicSize;
        // �}�E�X�z�C�[���̓��͂ɉ����ĕω��ʂ�ς���
        chengeValue = inputValue < 0 ? chengeValue : chengeValue * -1;
        // �ύX��̒l
        afterCamSize = afterCamSize + chengeValue;

        // �ݒ肵���ő�l�������Ă�����C������
        if (afterCamSize > _maxOrthographicSize)
        {
            afterCamSize = _maxOrthographicSize;
        }

        // �ݒ肵���ŏ��l�����܂���Ă�����C������
        if (afterCamSize < _minOrthographicSize)
        {
            afterCamSize = _minOrthographicSize;
        }

        _mainCamera.orthographicSize = afterCamSize;
    }
}
