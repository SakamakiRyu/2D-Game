using UnityEngine;

/// <summary>
/// �v���C���[���B�e����J�����̑���R���|�[�l���g
/// </summary>
public class PlayerFilmingCameraController : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private GameObject _target;

    [SerializeField]
    private float _minOrthographicSize;

    [SerializeField]
    private float _maxOrthographicSize;

    [SerializeField]
    private float _chengeValue;

    private void Update()
    {
        if (CheckMouseWheelInput())
        {
            OnChengedMouseWheelValue();
        }
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
        var afterCamSize = _camera.orthographicSize;
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

        _camera.orthographicSize = afterCamSize;
    }
}
