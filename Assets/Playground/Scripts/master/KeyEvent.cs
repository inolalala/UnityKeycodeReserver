using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace KeyCodeReserve
{
    [System.Serializable]
    public struct ReservedKeyEvent
    {
        public KeyCode key;
        public UnityEvent keyEvent;

        public void InvokeKeyEvent()
        {
            if(keyEvent != null)
            {
                keyEvent.Invoke();
            }
        }
    }
}
