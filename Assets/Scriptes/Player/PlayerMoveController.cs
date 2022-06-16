using System;
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
        Move();
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
    /// 動く
    /// </summary>
    private void Move()
    {
        if (Input.GetButton("Fire3")) // 左シフト
        {
            Sprint();
        }
        else
        {
            Walk();
        }
    }

    /// <summary>
    /// 移動入力の取得
    /// </summary>
    /// <returns>入力された方向ベクトル</returns>
    private Vector2 GetInputDirection()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");
        var dir = Vector2.right * hori + Vector2.up * ver;

        return dir;
    }

    /// <summary>
    /// 歩く
    /// </summary>
    private void Walk()
    {
        var dir = GetInputDirection();
        var velo = dir * _date.GetWalkingSpeed;
        _rb.velocity = velo;
    }

    /// <summary>
    /// 走る
    /// </summary>
    private void Sprint()
    {
        var dir = GetInputDirection();
        var velo = dir * _date.GetSprintSpeed;
        _rb.velocity = velo;
    }
    #endregion
}
