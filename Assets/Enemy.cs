using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniversWar
{
    [RequireComponent(typeof(EnemyCanon), typeof(EnemyMover))]
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private EnemyCanon _enemyCanon;

        [SerializeField]
        private EnemyMover _enemyMover;
    }
}
