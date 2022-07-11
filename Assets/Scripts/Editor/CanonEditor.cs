using UnityEditor;
using UnityEngine;

namespace UniversWar
{
    [CustomEditor(typeof(Canon))]
    public class CanonEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var canon = target as Canon;

            if (GUILayout.Button("Add Muzzle"))
            {
                AddMuzzle(canon);
            }
        }

        /// <summary>
        /// muzzle‚ð’Ç‰Á‚·‚é
        /// </summary>
        /// <param name="canon"></param>
        private void AddMuzzle(Canon canon)
        {
            var muzzle = new GameObject("Muzzle");
            var parent = canon.transform;
            muzzle.transform.SetParent(parent, true);
            canon.AddElementToArray();
        }
    }
}
