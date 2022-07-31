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
        }
    }
}