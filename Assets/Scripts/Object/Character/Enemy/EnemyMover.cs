using System;
using UnityEngine;

namespace UniversWar
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyMover : MonoBehaviour
    {
        public float Radius { get; set; }
        public float MoveSpeed { get; set; }

        private Rigidbody2D _rb2d;

        private Vector3 _basePos;

        private void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _basePos = transform.position;
        }

        private void Update()
        {
            transform.position = CircleMove(Radius, MoveSpeed);
        }

        private Vector3 CircleMove(float radius, float moveSpeed)
        {
            var y = _basePos.y + (radius * Mathf.Sin(Time.time * moveSpeed));
            return new Vector3(_basePos.x, y, 0f);
        }
    }
}
