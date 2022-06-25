using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    [SerializeField]
    private Renderer _renderer;

    [SerializeField]
    private float _scrollSpeed;

    private void Update()
    {
        var value = Mathf.Repeat(Time.time * _scrollSpeed, 1);
        var offset = new Vector2(value, value);

        _renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
