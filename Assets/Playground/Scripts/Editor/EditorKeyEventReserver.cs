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

            GUI.color = ConverHexColor("#c0c0ff");
            if (GUILayout.Button("Reserve"))
            {
                keyEventReserver.Reserve();
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
