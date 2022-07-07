using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
            
    }

    private void OnEnable()
    {
        ServiceLocator<GameManager>.Bind(this);
    }

    private void OnDisable()
    {
        ServiceLocator<GameManager>.UnBind(this);
    }

    public void ToString(string str)
    {
        Debug.Log(str);
    }
}
