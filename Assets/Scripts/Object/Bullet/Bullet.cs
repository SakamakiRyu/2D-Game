using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// 弾コンポーネント
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private BulletDateBase _dataBase;

        [SerializeField]
        private BulletDate.BulletType _type;

        [SerializeField]
        private Rigidbody2D _rb2d;

        private BulletDate _date;

        private void Awake()
        {
            _dataBase.GetBulletDate(_type);
        }

        private void OnEnable()
        {
            if (_date is null)
            {
                _dataBase.GetBulletDate(_type);
            }
        }

        public void Fire(Vector2 firePoint)
        {
            var velo = _date.CreateVelocity(_type, firePoint, null);
            _rb2d.velocity = velo;
        }

        /// <summary>
        /// 弾の種類を変える
        /// </summary>
        private void ChengeBulletType(BulletDate.BulletType type)
        {
            _type = type;
        }
    }
}