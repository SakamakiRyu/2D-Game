using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDate", menuName = "Date/Enemy")]
public class EnemyDate : ScriptableObject
{
    [SerializeField]
    private int _maxHP;
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _redius;
    [SerializeField]
    private EnemyCanonDate _canonDate;

    public int MaxHP => _maxHP;
    public float MoveSpeed => _moveSpeed;
    public float Redius => _redius;
    public EnemyCanonDate CanonDate => _canonDate;
}
