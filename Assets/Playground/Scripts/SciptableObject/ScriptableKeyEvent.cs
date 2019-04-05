using UnityEngine;
using UnityEngine.Events;

namespace KeyCodeReserve
{
    public class ScriptableKeyEvent : ScriptableObject
    {
        public KeyCode key;
        public UnityEvent keyEvent;

    }
}
