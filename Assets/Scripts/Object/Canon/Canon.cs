using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// 砲台コンポーネント
    /// </summary>
    public sealed class Canon : MonoBehaviour
    {
        [SerializeField]
        private Transform _muzzleTransform;

        [SerializeField]
        private T _bulletPrefab;

        public void RequestFire(Vector2 dir) => Fire(dir);

        /// <summary>
        /// 弾を発射する
        /// </summary>
        /// <param name="direction">発射する方向</param>
        private void Fire(Vector2 direction)
        {
            var bullet = CreateBullet(_bulletPrefab, _muzzleTransform.position);
            bullet.GetComponent<T>();
            bullet.SetDirection(direction);
        }

        /// <summary>
        /// 弾を生成
        /// </summary>
        private T CreateBullet(T bullet, Vector3 createPos)
        {
            return Instantiate(bullet, createPos, Quaternion.identity);
        }
    }
}