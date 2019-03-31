using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeyCodeReserve
{
    [ExecuteInEditMode]
    public class ReservedKeyEventViewer : MonoBehaviour
    {
        [SerializeField, Header("DEBUG")]
        private List<ReservedKeyEvent> AllReservedKeyEvents;

        void Start()
        {
            UpdateList();
        }

        public void UpdateList()
        {
            Debug.Log("UpdateList is Called.");
            AllReservedKeyEvents = new List<ReservedKeyEvent>();
            AllReservedKeyEvents = ReservedKeyEventRepository.Instance.FetchAllKeyEvents();
        }

    }
}
