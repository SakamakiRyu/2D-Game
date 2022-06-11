using UnityEngine;

[CreateAssetMenu(fileName = "Item Date")]
public class ItemDate : ScriptableObject
{
    public enum ItemType
    {
        None,
        Heal
    }

    [SerializeField]
    private ItemType Type;

    [SerializeField]
    private string Name;

    [SerializeField]
    private int Value;
}