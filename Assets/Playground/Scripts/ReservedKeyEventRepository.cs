using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace KeyCodeReserve
{
    public class ReservedKeyEventRepository
    {
        private static ReservedKeyEventRepository _instance;
        public List<ReservedKeyEvent> keyEvents = new List<ReservedKeyEvent>();

        public static ReservedKeyEventRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReservedKeyEventRepository();
                }
                return _instance;
            }
        }

        public List<ReservedKeyEvent> GetAllKeyEvents()
        {
            return Instance.keyEvents;
        }
        public ReservedKeyEvent GetByIndex(int index)
        {
            return Instance.keyEvents[index];
        }
        public List<ReservedKeyEvent> GetByKeyCode(KeyCode keyCode)
        {
            List<ReservedKeyEvent> returnKeyEventList = new List<ReservedKeyEvent>();
            foreach (var keyEvent in Instance.keyEvents)
            {
                if (keyEvent.key == keyCode)
                {
                    returnKeyEventList.Add(keyEvent);
                }
            }
         
            return returnKeyEventList;
        }
        public void Add(List<ReservedKeyEvent> keyEvents)
        {
            Instance.keyEvents.AddRange(keyEvents);
        }

    }
}
