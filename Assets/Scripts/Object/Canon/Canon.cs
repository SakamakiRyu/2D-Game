using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// �C��R���|�[�l���g
    /// </summary>
    public sealed class Canon : MonoBehaviour
    {
        [SerializeField]
        private Transform _muzzleTransform;

        [SerializeField]
        private T _bulletPrefab;

        public void RequestFire(Vector2 dir) => Fire(dir);

        /// <summary>
        /// �e�𔭎˂���
        /// </summary>
        /// <param name="direction">���˂������</param>
        private void Fire(Vector2 direction)
        {
            var bullet = CreateBullet(_bulletPrefab, _muzzleTransform.position);
            bullet.GetComponent<T>();
            bullet.SetDirection(direction);
        }

        /// <summary>
        /// �e�𐶐�
        /// </summary>
        private T CreateBullet(T bullet, Vector3 createPos)
        {
            return Instantiate(bullet, createPos, Quaternion.identity);
        }
    }
}