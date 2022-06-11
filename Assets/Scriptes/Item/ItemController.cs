using UnityEngine;

/// <summary>
/// アイテムクラス
/// </summary>
public abstract class ItemBase : MonoBehaviour
{
    [SerializeField]
    private ItemDate _itemDate;

    public virtual void OnHit()
    {

    }

}