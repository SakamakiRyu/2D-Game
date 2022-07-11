using UnityEngine;
using DragonPackage;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        ServiceLocator<GameManager>.Bind(this);
    }

    private void OnDisable()
    {
        ServiceLocator<GameManager>.UnBind(this);
    }
}
