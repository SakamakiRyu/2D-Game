using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerActionController : MonoBehaviour
{
    [SerializeField]
    private float _moveingSpeed;

    [SerializeField]
    private Rigidbody2D _rb;

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        Walk();
    }

    /// <summary>
    /// èâä˙âª
    /// </summary>
    private void Init()
    {
        if (!_rb)
        {
            TryGetComponent(out _rb);
        }
    }

    /// <summary>
    /// ï‡Ç≠
    /// </summary>
    private void Walk()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");
        var dir = Vector2.right * hori + Vector2.up * ver;
        var velo = dir * _moveingSpeed;
        _rb.velocity = velo;
    }
}
