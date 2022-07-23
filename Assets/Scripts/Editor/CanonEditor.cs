using UnityEditor;

namespace UniversWar
{
    [CustomEditor(typeof(CanonBase))]
    public class CanonEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var canon = target as CanonBase;
        }
    }
}
