using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeReserve;

public class KeyEventInvoker : MonoBehaviour {

    private ReservedKeyEventRepository reservedKeyEventRepository;
    private List<ReservedKeyEvent> keyEvents;

    void Awake()
    {
        keyEvents = ReservedKeyEventRepository.Instance.GetAllKeyEvents();
    }


    void Update()
    {
        for (int i = 0; i < keyEvents.Count; i++)
        {
            ReservedKeyEvent keyEvent = keyEvents[i];
            if (Input.GetKeyDown(keyEvent.key))
            {
                keyEvent.InvokeKeyEvent();
            }
        }
    }

}
