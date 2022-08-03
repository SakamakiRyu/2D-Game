using UnityEngine;

namespace UniversWar
{
    [RequireComponent(typeof(PlayerStatus), typeof(PlayerCanon), typeof(PlayerMover))]
    public class Player : MonoBehaviour, IHitable
    {
        private PlayerStatus _status;
        private PlayerCanon _canon;
        private PlayerMover _mover;

        private void Start()
        {
            _status = GetComponent<PlayerStatus>();
        }

        public void OnHit()
        {
            _status.AddDamage();
        }
    }
}
