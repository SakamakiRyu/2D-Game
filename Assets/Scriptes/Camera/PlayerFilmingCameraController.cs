using UnityEngine;

/// <summary>
/// プレイヤーを撮影するカメラの操作コンポーネント
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
    /// マウスホイールの入力がされているか
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
    /// マウスホイールの入力をされた時に呼ばれる処理
    /// </summary>
    private void OnChengedMouseWheelValue()
    {
        // マウスホイールの入力
        var inputValue = Input.mouseScrollDelta.y;
        // 値の変化量
        var chengeValue = _chengeValue;
        // カメラの描画サイズ
        var afterCamSize = _camera.orthographicSize;
        // マウスホイールの入力に応じて変化量を変える
        chengeValue = inputValue < 0 ? chengeValue : chengeValue * -1;
        // 変更後の値
        afterCamSize = afterCamSize + chengeValue;

        // 設定した最大値を上回っていたら修正する
        if (afterCamSize > _maxOrthographicSize)
        {
            afterCamSize = _maxOrthographicSize;
        }

        // 設定した最小値を下まわっていたら修正する
        if (afterCamSize < _minOrthographicSize)
        {
            afterCamSize = _minOrthographicSize;
        }

        _camera.orthographicSize = afterCamSize;
    }
}
