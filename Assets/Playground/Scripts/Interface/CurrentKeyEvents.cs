using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KeyCodeReserve;

public class CurrentKeyEvents : MonoBehaviour {

    [SerializeField, Header("DEBUG")]
    private List<ReservedKeyEvent> AllReservedKeyEvents;

    void Start()
    {
        UpdateList();
    }

    public void UpdateList()
    {
        AllReservedKeyEvents = ReservedKeyEventRepository.Instance.GetAllKeyEvents();
    }

}
