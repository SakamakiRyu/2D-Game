using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �e�̃f�[�^���Ǘ�����X�N���v�^�u���I�u�W�F�N�g
/// </summary>
[CreateAssetMenu(fileName = "Create bullets date", menuName = "BulletsDate")]
public class BulletsDate : ScriptableObject
{
    #region Define
    /// <summary>
    /// �e�̎��
    /// </summary>
    public enum Type
    {
        None = -1,
        Normal,
    }

    /// <summary>
    /// �e�̃T�C�Y
    /// </summary>
    public enum Size
    {
        None = -1,
        S,
        M,
        L
    }

    /// <summary>
    /// �e�̃f�[�^
    /// </summary>
    [System.Serializable]
    public class Bullet
    {
        public string Name;
        public Type Type;
        public Size Size;
        public float Speed;
        public int Power;
    }
    #endregion

    /// <summary>
    /// �e�̃��X�g
    /// </summary>
    public Bullet[] BulletsArray;

    /// <summary>
    /// �e�̃f�[�^���擾
    /// </summary>
    public Bullet GetBulletDate(Type type, Size size)
    {
        foreach (var item in BulletsArray)
        {
            if (item.Type == type && item.Size == size)
            {
                return item;
            }
        }
        return null;
    }
}
