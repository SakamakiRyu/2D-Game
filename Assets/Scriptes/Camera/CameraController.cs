using UnityEngine;

/// <summary>
/// �J�����̊Ǘ��N���X
/// </summary>
public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private GameObject _target;

    private void Update()
    {
        SetPosition();
    }

    /// <summary>
    /// �J�����̍��W��ݒ肷��
    /// </summary>
    private void SetPosition()
    {
        var player = _target.transform.position;
        var camPos = new Vector3(player.x, player.y, -10f);
        _camera.transform.position = camPos;
    }
}
