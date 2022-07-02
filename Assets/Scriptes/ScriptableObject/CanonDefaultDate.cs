using System;
using UnityEngine;

/// <summary>
/// �C��̏����f�[�^���Ǘ�����X�N���v�^�u���I�u�W�F�N�g
/// </summary>
[CreateAssetMenu(fileName = "Create Canon Date", menuName = "Canon Date")]
public class CanonDefaultDate : ScriptableObject
{
    #region Define
    /// <summary>
    /// �C��
    /// </summary>
    [Serializable]
    public class Canon
    {
        public string Name;
        public BulletsDate.Type Type;
        public BulletsDate.Size Size;
    }

    /// <summary>
    /// �X�D�O�H�C�i�@�I�I�}�G�^�`�B�I
    /// </summary>
    public Canon[] DefaultDates;
    #endregion
}
