using UnityEngine;

/// <summary>
/// �w�i�̑���R���|�[�l���g
/// </summary>
public class BackGroundController : MonoBehaviour
{
    [SerializeField]
    private Renderer _renderer;

    [SerializeField]
    private float _scrollSpeed;

    // �w�i�̏c�X�N���[���l
    private const float OFFSET_Y = 0f;

    private void Update()
    {
        BackGroundScroll();
    }

    private void BackGroundScroll()
    {
        var value = Mathf.Repeat(Time.time * _scrollSpeed, 1);
        var offset = new Vector2(value, OFFSET_Y);

        _renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
