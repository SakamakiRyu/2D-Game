using UnityEngine;
using UnityEngine.UI;

namespace UniversWar
{
    /// <summary>
    /// íeÇÃèÓïÒ
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
        /// íeÇÃãììÆÇê∂ê¨Ç∑ÇÈ
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
        /// âEÇ…å¸Ç©Ç¡Çƒê^Ç¡Ç∑ÇÆîÚÇ‘
        /// </summary>
        /// <returns></returns>
        private Vector2 Straight()
        {
            return Vector2.right;
        }

        /// <summary>
        /// í«îˆÇ∑ÇÈ
        /// </summary>
        private Vector2 Lockon(Vector2 origin, Vector2 target)
        {
            return target - origin;
        }
    }
}
