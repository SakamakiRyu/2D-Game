using UnityEngine;

namespace UniversWar
{
    public abstract class CanonBase : MonoBehaviour
    {
        #region Field
        [SerializeField]
        protected Transform _muzzleTransform;

        [SerializeField]
        protected float _bulletSpeed;
        #endregion

        protected abstract void Fire();
    }
}