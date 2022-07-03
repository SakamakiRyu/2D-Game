using System;
using UnityEngine;

/// <summary>
/// �C��̏����f�[�^���Ǘ�����X�N���v�^�u���I�u�W�F�N�g
/// </summary>
[CreateAssetMenu(fileName = "Create Canon Date", menuName = "Canon Date")]
public class CanonDate : ScriptableObject
{
    #region Define
    /// <summary>
    /// �C��
    /// </summary>
    [Serializable]
    public class Canon
    {
        public string Name;
        public BulletDate.Type Type;
        public BulletDate.Size Size;
    }

    public Canon DefaultDates;
    #endregion
}
