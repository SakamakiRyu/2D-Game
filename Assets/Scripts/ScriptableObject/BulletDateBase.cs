using UnityEditor;
using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// 弾の情報を管理するスクリプタブルオブジェクト
    /// </summary>
    [CreateAssetMenu(menuName = "Date/Bullet DateBase")]
    public class BulletDateBase : Editor
    {
        [SerializeField]
        private BulletDate[] BulletsDateArray;

        /// <summary>
        /// 弾の情報を取得
        /// </summary>
        public BulletDate GetBulletDate(BulletDate.BulletType type)
        {
            return BulletsDateArray[(int)type];
        }

        private void OnValidate()
        {
            for (int i = 0; i < BulletsDateArray.Length; i++)
            {
                BulletsDateArray[i].ID = i;
            }
        }
    }
}