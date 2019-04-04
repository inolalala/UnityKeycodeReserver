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
            EditorGUILayout.BeginHorizontal();
            {
                GUI.color = ConverHexColor("#ffdddd");
                if (GUILayout.Button("Refresh by KeyCode"))
                {
                    keyEventRefresher.RefreshByKeyCode();
                }

                GUI.color = ConverHexColor("#ffdddd");
                if (GUILayout.Button("Refresh by Index"))
                {
                    keyEventRefresher.RefreshByIndex();
                }
            }
            EditorGUILayout.EndHorizontal();
            
            GUI.color = ConverHexColor("#ff6d6d");
            if (GUILayout.Button("Refresh All"))
            {
                keyEventRefresher.RefreshAll();
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
