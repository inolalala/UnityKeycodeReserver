using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace KeyCodeReserve
{
    [CustomEditor(typeof(KeyEventReserver))]
    public class EditorKeyEventReserver : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            KeyEventReserver keyEventReserver = target as KeyEventReserver;

            if (GUILayout.Button("Reserve"))
            {
                keyEventReserver.Reserve();
            }
        }
    }
}
