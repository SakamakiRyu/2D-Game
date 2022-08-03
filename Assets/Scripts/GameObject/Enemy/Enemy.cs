using UnityEngine;

namespace UniversWar
{
    /// <summary>
    /// 敵の中継クラス
    /// </summary>
    [RequireComponent(typeof(EnemyCanon), typeof(EnemyMover), typeof(EnemyStatus))]
    public class Enemy : MonoBehaviour, IHitable
    {
        [SerializeField]
        private EnemyDate _date;

        private Animator _anim;

        private EnemyCanon _canon;
        private EnemyMover _mover;
        private EnemyStatus _status;

        private void Awake()
        {
            _anim = GetComponent<Animator>();
            _canon = GetComponent<EnemyCanon>();
            _mover = GetComponent<EnemyMover>();
            _status = GetComponent<EnemyStatus>();
        }

        private void Start()
        {
            // Moverのセット
            _mover.Radius = _date.Redius;
            _mover.MoveSpeed = _date.MoveSpeed;

            // ステータスのセット
            _status.SetHP(_date.MaxHP);
        }

        private void DisableAnimator()
        {
            _anim.enabled = false;
        }

        public void OnHit()
        {
            _status.AddDamage();
        }
    }
}
