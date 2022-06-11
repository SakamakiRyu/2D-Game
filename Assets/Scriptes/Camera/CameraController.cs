using UnityEngine;

/// <summary>
/// カメラの管理クラス
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
    /// カメラの座標を設定する
    /// </summary>
    private void SetPosition()
    {
        var player = _target.transform.position;
        var camPos = new Vector3(player.x, player.y, -10f);
        _camera.transform.position = camPos;
    }
}
