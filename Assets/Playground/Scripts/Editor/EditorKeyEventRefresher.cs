using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace KeyCodeReserve
{
    [CustomEditor(typeof(KeyEventRefresher))]
    public class EditorKeyEventRefresher : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            KeyEventRefresher keyEventRefresher = target as KeyEventRefresher;

            if(GUILayout.Button("Refresh by KeyCode"))
            {
                keyEventRefresher.RefreshByKeyCode();
            }

            if (GUILayout.Button("Refresh All"))
            {
                keyEventRefresher.RefreshAll();
            }

        }
    }
}
