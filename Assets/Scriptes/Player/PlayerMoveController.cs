using UnityEngine;

/// <summary>
/// プレイヤーの物理挙動を操作するコンポーネント
/// </summary>
[RequireComponent(typeof(Rigidbody2D), typeof(PlayerDateController))]
public class PlayerMoveController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private PlayerDateController _date;

    [SerializeField]
    private Rigidbody2D _rb;
    #endregion

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        Walk();
    }

    #region Private Field
    /// <summary>
    /// 初期化
    /// </summary>
    private void Init()
    {
        CheckReferencedComponents();
    }

    /// <summary>
    /// 必要コンポーネントが参照できているかの確認
    /// </summary>
    private bool CheckReferencedComponents()
    {
        if (_rb is null)
        {
            Debug.LogError("Doesn't reference a RigitBody2D !");
            return false;
        }

        if (_date is null)
        {
            Debug.LogError("Doesn't Reference a PlayerDateController !");
            return false;
        }
        return true;
    }

    /// <summary>
    /// 歩く
    /// </summary>
    private void Walk()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");
        var dir = Vector2.right * hori + Vector2.up * ver;
        var velo = dir * _date.GetWalkingSpeed;
        _rb.velocity = velo;
    }
    #endregion
}
