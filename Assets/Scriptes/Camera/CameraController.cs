using UnityEngine;

/// <summary>
/// プレイヤーを撮影するカメラの操作コンポーネント
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
