using UnityEngine;

namespace UniversWar
{
    public class PlayerStatus : StatusBase
    {
        [SerializeField]
        private int _maxHP;

        private void Awake()
        {
            CurrentHP = _maxHP;
        }

        public void AddDamage()
        {
            CurrentHP--;
        }
    }
}
