using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace KeyCodeReserve
{
    public class KeyCodeReserver : MonoBehaviour
    {

        [SerializeField] private List<ReservedKeyEvent> keyEvents = new List<ReservedKeyEvent>();

        private ReservedKeyEventRepository reservedKeyEventRepository;

        void Awake()
        {
            reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
            reservedKeyEventRepository.Add(keyEvents);
        }

        /*
        private void Update()
        {
            for (int i = 0; i < GetUsingKeyCodes().Count; i++)
            {
                ReservedKeyEvent pressedKeyCode = GetUsingKeyCodes()[i];
                if (Input.GetKeyDown(pressedKeyCode.key))
                {
                    pressedKeyCode.keyEvent.Invoke();
                }
            }
        }
        */

    }
}
