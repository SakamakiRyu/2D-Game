using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMover : MonoBehaviour
{
    public enum MovePattern
    {
        None,
        Circle
    }

    [SerializeField]
    private float _movingSpeed;

    [SerializeField]
    private float _redius;

    private Rigidbody2D _rb2d;

    private MovePattern _movePattern { get; set; } = MovePattern.None;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _movePattern = MovePattern.Circle;
    }

    private void Update()
    {
        switch (_movePattern)
        {
            case MovePattern.None:
                break;
            case MovePattern.Circle:
                transform.position = CircleMove(_redius, _movingSpeed);
                break;
            default:
                break;
        }
    }

    private Vector3 CircleMove(float radius, float moveSpeed)
    {
        var y = radius * Mathf.Sin(Time.time * moveSpeed);
        return new Vector3(0f, y, 0f);
    }
}

