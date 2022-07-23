using UnityEngine;
using UnityEngine.InputSystem;
using DragonPackage;

namespace UniversWar
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class PlayerMover : MonoBehaviour
    {
        #region Field
        [SerializeField]
        private float _movingSpeed;

        private Rigidbody2D _rb2d;
        #endregion

        #region Property
        #endregion

        #region Unity Function
        private void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
        }

        private void OnValidate()
        {
            if (_rb2d)
            {
                _rb2d.gravityScale = 0f;
            }
        }
        #endregion

        public void OnMove(InputAction.CallbackContext context)
        {
            var dir  = context.ReadValue<Vector2>();
            var velo = CreateVelocity(dir);
            _rb2d.SetVelocity(velo);
        }

        private Vector2 CreateVelocity(Vector2 dir)
        {
            return dir * _movingSpeed;
        }
    }
}