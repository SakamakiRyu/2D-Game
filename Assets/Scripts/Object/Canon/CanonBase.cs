using UnityEngine;

namespace UniversWar
{
    public abstract class CanonBase : MonoBehaviour
    {
        #region Field
        [SerializeField]
        protected Transform _muzzleTransform;
        #endregion

        protected abstract void Fire();
    }
}