using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace KeyCodeReserve
{
    public class KeyEventConfig : ScriptableObject
    {
        private List<ReservedKeyEvent> reservedKeyEvents;
    }
}
