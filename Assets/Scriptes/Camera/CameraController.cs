using UnityEngine;

/// <summary>
/// �v���C���[���B�e����J�����̑���R���|�[�l���g
/// </summary>
public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private Transform _followTarget;

    [SerializeField]
    private float _maxOrthographicSize;

    [SerializeField]
    private float _minOrthographicSize;

    private void Start()
    {
    }

    private void Update()
    {
    }
}
