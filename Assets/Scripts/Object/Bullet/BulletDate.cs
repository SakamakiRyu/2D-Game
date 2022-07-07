using UnityEngine;
using UnityEngine.UI;

namespace UniversWar
{
    /// <summary>
    /// 弾の情報
    /// </summary>
    [System.Serializable]
    public class BulletDate
    {
        #region Define
        public enum BulletType
        {
            None = -1,
            NormalS,
            NormalM,
            NormalL
        }
        #endregion

        #region Field
        public string Name;
        public BulletType Type;
        public int ID;
        public float Power;
        public Image Image;
        #endregion

        /// <summary>
        /// 弾の挙動を生成する
        /// </summary>
        public Vector2 CreateVelocity(BulletType type, Vector2 origin, Vector2? target)
        {
            var velo = Vector2.right;

            if (target is null)
                target = Vector2.right;

            switch (type)
            {
                case BulletType.None:
                    break;

                case BulletType.NormalS:
                    velo = Straight();
                    break;

                case BulletType.NormalM:
                    velo = Lockon(origin, (Vector2)target);
                    break;

                case BulletType.NormalL:
                    velo = Straight();
                    break;

                default:
                    velo = Straight();
                    break;
            }

            return velo;
        }

        /// <summary>
        /// 右に向かって真っすぐ飛ぶ
        /// </summary>
        /// <returns></returns>
        private Vector2 Straight()
        {
            return Vector2.right;
        }

        /// <summary>
        /// 追尾する
        /// </summary>
        private Vector2 Lockon(Vector2 origin, Vector2 target)
        {
            return target - origin;
        }
    }
}
