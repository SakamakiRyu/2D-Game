using UnityEngine;
using DragonPackage;

namespace UniversWar
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _playerPrefab;

        [SerializeField]
        private Transform _playerSpawnPoint;

        private void Start()
        {
            SpawnPlayer();
        }

        private void OnEnable()
        {
            ServiceLocator<GameManager>.Bind(this);
        }

        private void OnDisable()
        {
            ServiceLocator<GameManager>.UnBind(this);
        }

        private void SpawnPlayer()
        {
            var go = Instantiate(_playerPrefab);
            go.transform.position = _playerSpawnPoint.position;
        }
    }
}