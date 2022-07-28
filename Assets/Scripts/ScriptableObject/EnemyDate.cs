using UnityEngine;

[CreateAssetMenu(menuName = "Date/Enemy/Status")]
public class EnemyDate : ScriptableObject
{
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _redius;

    public float MoveSpeed => _moveSpeed;
    public float Redius => _redius;
}
