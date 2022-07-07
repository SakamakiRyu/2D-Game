using UnityEditor;
using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// �e�̏����Ǘ�����X�N���v�^�u���I�u�W�F�N�g
    /// </summary>
    [CreateAssetMenu(menuName = "Date/Bullet DateBase")]
    public class BulletDateBase : Editor
    {
        [SerializeField]
        private BulletDate[] BulletsDateArray;

        /// <summary>
        /// �e�̏����擾
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