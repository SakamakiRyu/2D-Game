using UnityEngine;
using UnityEngine.InputSystem;

namespace UniversWar
{
    /// <summary>
    /// �C��R���|�[�l���g
    /// </summary>
    public class Canon : MonoBehaviour
    {
        [SerializeField]
        private Transform _muzzleTransform;

        [SerializeField]
        private Bullet _bulletPrefab;

        public void OnFire(InputAction.CallbackContext context)
        {
            if (context.started)
            {

            }
        }

        public void Fire(Bullet bulletObject, Vector2 velocity)
        {

        }
    }
}