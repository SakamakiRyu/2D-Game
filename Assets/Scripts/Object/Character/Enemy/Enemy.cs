using UnityEngine;

namespace UniversWar
{
    [RequireComponent(typeof(EnemyCanon), typeof(EnemyMover), typeof(EnemyStatus))]
    public class Enemy : MonoBehaviour, IHitable
    {
        [SerializeField]
        private Player _player;
        [SerializeField]
        private EnemyDate _date;

        private EnemyCanon _canon;
        private EnemyMover _mover;
        private EnemyStatus _status;

        private void Awake()
        {
            _canon = GetComponent<EnemyCanon>();
            _mover = GetComponent<EnemyMover>();
            _status = GetComponent<EnemyStatus>();
        }

        private void Start()
        {
            // Canon�̃Z�b�g
            _canon.CanonDate = _date.CanonDate;
            _canon.Player = _player;

            // Mover�̃Z�b�g
            _mover.Radius = _date.Redius;
            _mover.MoveSpeed = _date.MoveSpeed;

            // �X�e�[�^�X�̃Z�b�g
            _status.SetHP(_date.MaxHP);
        }

        public void OnHit()
        {
            _status.AddDamage();
        }
    }
}
