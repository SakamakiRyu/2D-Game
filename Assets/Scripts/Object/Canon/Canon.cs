using UnityEngine;
using System.Collections;
using DragonPackage;

namespace UniversWar
{
    /// <summary>
    /// 砲台コンポーネント
    /// </summary>
    public sealed class Canon : MonoBehaviour
    {
        #region Field
        [SerializeField]
        private Transform _muzzleTransform;

        [SerializeField]
        private BulletManager _bulletManager; 

        [SerializeField]
        private float _defaultInterval = 0.5f;

        private float _interval = 0f;
        #endregion

        private void Awake()
        {
            _interval = _defaultInterval;
        }

        private void Start()
        {
            RequestFire(Vector2.right);
        }

        /// <summary>
        /// インターバルを変更する
        /// </summary>
        /// <param name="interval"></param>
        public void ChengeInterval(float interval)
        {
            _interval = interval;
        }

        /// <summary>
        /// 弾の発射リクエスト
        /// </summary>
        public void RequestFire(Vector2 dir)
        {
            StartCoroutine(FireAsync(this.transform, dir));
        }

        /// <summary>
        /// 弾を発射する
        /// </summary>
        private IEnumerator FireAsync(Transform transform, Vector2 dir)
        {
            while (true)
            {
                // インターバル
                yield return IEnumeratorExtensions.WaitAsync(_interval);
                // 弾の生成
                var bullet = _bulletManager.GetBullet(transform);
                // 弾の情報を設定する
                bullet.SetDate(_muzzleTransform.position, dir);
                yield return null;
            }
        }
        #region Editor
        #endregion
    }
}