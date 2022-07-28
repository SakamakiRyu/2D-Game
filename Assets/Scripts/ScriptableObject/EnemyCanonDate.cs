using UnityEngine;

[CreateAssetMenu(fileName = "EnemyCanon", menuName = "Date/Enemy/Canon")]
public class EnemyCanonDate : ScriptableObject
{
    [SerializeField]
    private float _bulletSpeed;
    [SerializeField]
    private float _range;
    [SerializeField]
    private float _chargeTime;

    public float BulletSpeed => _bulletSpeed;
    public float Range => _range;
    public float ChargeTime => _chargeTime;
}
