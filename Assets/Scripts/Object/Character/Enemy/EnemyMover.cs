using System;
using UnityEngine;

namespace UniversWar
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField]
        private EnemyDate _date;

        private Rigidbody2D _rb2d;

        private Vector3 _basePos;

        private void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
            _basePos = transform.position;
        }

        private void Update()
        {
            transform.position = CircleMove(_date.Redius, _date.MoveSpeed);
        }

        private Vector3 CircleMove(float radius, float moveSpeed)
        {
            var y = _basePos.y + (radius * Mathf.Sin(Time.time * moveSpeed));
            return new Vector3(_basePos.x, y, 0f);
        }
    }
}
