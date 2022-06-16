using System;
using UnityEngine;

/// <summary>
/// �v���C���[�̕��������𑀍삷��R���|�[�l���g
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
    /// ������
    /// </summary>
    private void Init()
    {
        CheckReferencedComponents();
    }

    /// <summary>
    /// �K�v�R���|�[�l���g���Q�Ƃł��Ă��邩�̊m�F
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
    /// ����
    /// </summary>
    private void Move()
    {
        if (Input.GetButton("Fire3")) // ���V�t�g
        {
            Sprint();
        }
        else
        {
            Walk();
        }
    }

    /// <summary>
    /// �ړ����͂̎擾
    /// </summary>
    /// <returns>���͂��ꂽ�����x�N�g��</returns>
    private Vector2 GetInputDirection()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");
        var dir = Vector2.right * hori + Vector2.up * ver;

        return dir;
    }

    /// <summary>
    /// ����
    /// </summary>
    private void Walk()
    {
        var dir = GetInputDirection();
        var velo = dir * _date.GetWalkingSpeed;
        _rb.velocity = velo;
    }

    /// <summary>
    /// ����
    /// </summary>
    private void Sprint()
    {
        var dir = GetInputDirection();
        var velo = dir * _date.GetSprintSpeed;
        _rb.velocity = velo;
    }
    #endregion
}
