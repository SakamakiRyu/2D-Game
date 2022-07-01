using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �e�̃f�[�^���Ǘ�����X�N���v�^�u���I�u�W�F�N�g
/// </summary>
[CreateAssetMenu(fileName ="Create bullets date",menuName = "BulletsDate")]
public class BulletDate : ScriptableObject
{
    #region Define
    /// <summary>
    /// �e�̎��
    /// </summary>
    public enum Type
    {
        None = -1,
        Normal
    }

    /// <summary>
    /// �e�̃f�[�^
    /// </summary>
    [System.Serializable]
    public class Bullet
    {
        public string Name;
        public Type Type;
        public float Speed;
        public int Power;
    }
    #endregion

    /// <summary>
    /// �e�̃��X�g
    /// </summary>
    public List<Bullet> BulletsList;

    public Bullet GetBulletDate(Type type)
    {
        return BulletsList[(int)type];
    }

    public string GetBulletName(Type type)
    {
        return BulletsList[(int)type].Name;
    }

    public float GetBulletSpeed(Type type)
    {
        return BulletsList[(int)type].Speed;
    }

    public int GetBulletPower(Type type)
    {
        return BulletsList[((int)type)].Power;
    }
}
