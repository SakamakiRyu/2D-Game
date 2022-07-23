using UnityEngine;
using DragonPackage;

namespace UniversWar
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        #region Field
        private Rigidbody2D _rb2d;
        #endregion

        #region Unity Function
        private void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
        }

        private void OnBecameInvisible()
        {
            this.gameObject.SetActive(false);
        }
        #endregion

        #region Public Function
        public void Shoot(Vector2 direction, float speed)
        {
            var velo = direction * speed;
            _rb2d.SetVelocity(velo);
        }
        #endregion
    }
}