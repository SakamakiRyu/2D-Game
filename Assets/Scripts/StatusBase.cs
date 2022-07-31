using UnityEngine;

public class StatusBase : MonoBehaviour
{
    public int CurrentHP { get; protected set; }

    public void AddDamage(int damage = 1)
    {
        CurrentHP--;
    }
}
