using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace KeyCodeReserve
{
    [CustomEditor(typeof(ReservedKeyEventViewer))]
    public class EditorReservedKeyEventViewer : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            ReservedKeyEventViewer reservedKeyEventViewer = target as ReservedKeyEventViewer;

            if (GUILayout.Button("Update List"))
            {
                reservedKeyEventViewer.UpdateList();
            }
        }
    }
}

