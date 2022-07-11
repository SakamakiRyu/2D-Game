using UnityEditor;

namespace UniversWar
{
    [CustomEditor(typeof(PlayerMover))]
    public class PlayerMoverEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var mover = target as PlayerMover;
        }
    }
}
