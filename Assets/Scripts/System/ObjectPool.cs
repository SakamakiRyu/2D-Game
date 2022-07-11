using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonPackage
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField]
        private GameObject _pooledObject;

        [SerializeField]
        private float _defaultCapacity;

        private List<GameObject> ObjectsList;

        private int _index = 0;

        private void Start()
        {
            for (int i = 0; i < _defaultCapacity; i++)
            {
                var go = Instantiate(_pooledObject);
                go.SetActive(true);
            }
        }

        public GameObject GetObject(Vector3 pos)
        {
            if (_index > _defaultCapacity)
                _index++;
            else
                _index = 0;

            var obj = ObjectsList[_index];
            obj.transform.position = pos;

            if (obj.activeSelf is false)
                return obj;
            else
                return GetObject(pos);
        }
    }
}