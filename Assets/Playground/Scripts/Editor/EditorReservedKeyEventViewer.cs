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

            GUI.color = ConverHexColor("#b3b3b3");
            if (GUILayout.Button("Update List"))
            {
                reservedKeyEventViewer.UpdateList();
            }
        }
        private Color ConverHexColor(string convertTarget)
        {
            Color resultColor = new Color();
            ColorUtility.TryParseHtmlString(convertTarget, out resultColor);
            return resultColor;
        }
    }
}

