using UnityEngine;
using UnityEngine.InputSystem;

namespace UniversWar
{
    /// <summary>
    /// InputSystem‚ÆPlayer‚Ì’‡‰îƒNƒ‰ƒX
    /// </summary>
    public sealed class InputSystemToPlayer : MonoBehaviour
    {
        [SerializeField]
        private PlayerMover _mover;

        [SerializeField]
        private Canon _canon;

        public void OnMove(InputAction.CallbackContext context)
        {
            var dir = context.ReadValue<Vector2>();
            _mover.RequestMove(dir);
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                _canon.RequestFire(Vector2.right);
            }
        }
    }
}
