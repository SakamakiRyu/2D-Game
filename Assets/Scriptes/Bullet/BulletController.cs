using UnityEngine;

/// <summary>
/// �e�̕����������Ǘ�����N���X
/// </summary>
[RequireComponent(typeof(Rigidbody2D), (typeof(CircleCollider2D)))]
public class BulletController : MonoBehaviour
{
    #region Field
    [SerializeField]
    private Rigidbody2D _rb2d;

    [SerializeField]
    private CircleCollider2D _collider;
    #endregion

    #region Unity Fucntion
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            OnHit();
        }
    }

    private void OnValidate()
    {
        if (_rb2d == null)
        {
            TryGetComponent(out _rb2d);
            _rb2d.gravityScale = 0f;
        }

        if (_collider == null)
        {
            TryGetComponent(out _collider);
            if (_collider)
            {
                _collider.isTrigger = true;
            }
        }
    }
    #endregion

    #region Public Fucntion
    /// <summary>
    /// �e�����˂��ꂽ���̏���
    /// </summary>
    /// <param name="dir">���˂̕���</param>
    public void Fired(Vector2 dir)
    {

    }

    /// <summary>
    /// �e�����������ۂ̏���
    /// </summary>
    public void OnHit()
    {

    }
    #endregion
}
