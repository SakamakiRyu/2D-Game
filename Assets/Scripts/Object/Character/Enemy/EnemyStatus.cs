namespace UniversWar
{
    public class EnemyStatus : StatusBase
    {
        public void SetHP(int hp)
        {
            CurrentHP = hp;
        }

        public void AddDamage()
        {
            CurrentHP--;

            if (IsDead())
            {
                this.gameObject.SetActive(false);
            }
        }

        private bool IsDead()
        {
            return CurrentHP < 0;
        }
    }
}