using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : StatusBase
{
    [SerializeField]
    private int _maxHP;

    public void AddDamage()
    {
        CurrentHP--;
        Debug.Log("Damage");
    }
}
