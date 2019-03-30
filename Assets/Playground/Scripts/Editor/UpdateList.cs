using UnityEngine;
using UnityEditor;

namespace KeyCodeReserve
{
    [CustomEditor(typeof(CurrentKeyEvents))]
    public class UpdateList : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            CurrentKeyEvents currentKeyEvent = target as CurrentKeyEvents;

            if (GUILayout.Button("Update KeyEventList"))
            {
                currentKeyEvent.UpdateList();
            }
        }

    }
}
