using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Date/Bullet DateBase")]
public class BulletDateBase : Editor
{
    public BulletDate[] BulletsDateArray;

    public BulletDate GetBulletDate(int ID)
    {
        return BulletsDateArray[ID];
    }

    private void OnValidate()
    {
        for (int i = 0; i < BulletsDateArray.Length; i++)
        {
            BulletsDateArray[i].ID = i;
        }
    }
}
