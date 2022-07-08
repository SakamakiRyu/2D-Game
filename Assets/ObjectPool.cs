using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    private GameObject _go;

    private ObjectPool<GameObject> Pool;

    private void Awake()
    {
        Pool = new ObjectPool<GameObject>(
            OnCreatePoolObject,
            OnGetFromPool,
            OnReleaseToPool,
            OnDestroyPooledObject
            );
    }

    public GameObject OnCreatePoolObject()
    {
        return Instantiate(_go);
    }

    private void OnGetFromPool(GameObject go)
    {
        go.SetActive(true);
    }

    private void OnReleaseToPool(GameObject go)
    {
        go.SetActive(false);
    }

    private void OnDestroyPooledObject(GameObject go)
    {
        Destroy(go);
    }

    public GameObject GetGameObject(GameObject go, Vector3 position, Quaternion rotation)
    {
        _go = go;
        var obj = Pool.Get();
        var transform = obj.transform;
        transform.position = position;
        transform.rotation = rotation;
        return obj;
    }

    public void ReleaseGameObject(GameObject go)
    {
        Pool.Release(go);
    }
}