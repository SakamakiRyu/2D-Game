using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// �C��R���|�[�l���g
    /// </summary>
    public sealed class Canon : MonoBehaviour
    {
        [SerializeField]
        private Transform[] MuzzlesTransform;

        [SerializeField]
        private Bullet _bulletPrefab;

        public void RequestFire(Vector2 dir) => Fire(dir);

        /// <summary>
        /// �e�𔭎˂���
        /// </summary>
        /// <param name="direction">���˂������</param>
        private void Fire(Vector2 direction)
        {
            var bullet = CreateBullet(_bulletPrefab, MuzzlesTransform[0].position);
            bullet.GetComponent<Bullet>();
            bullet.SetDirection(direction);
        }

        /// <summary>
        /// �e�𐶐�
        /// </summary>
        private Bullet CreateBullet(Bullet bullet, Vector3 createPos)
        {
            return Instantiate(bullet, createPos, Quaternion.identity);
        }

        public void AddElementToArray()
        {
            GetMuzzleFromChildren();
        }

        /// <summary>
        /// ���g�̎q�I�u�W�F�N�g��Muzzle�ɐݒ肷��
        /// </summary>
        private void GetMuzzleFromChildren()
        {
            var muzzles = this.GetComponentsInChildrenOnly<Transform>();
            MuzzlesTransform = muzzles;
        }
    }
}