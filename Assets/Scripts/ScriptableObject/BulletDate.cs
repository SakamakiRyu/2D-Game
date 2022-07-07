using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Date/Bullet Date")]
public class BulletDate : Editor
{
    #region Define
    public enum BulletType
    {
        None,
        Normal
    }
    #endregion

    public BulletType Type;
    public string Name;
    public int ID;
}
