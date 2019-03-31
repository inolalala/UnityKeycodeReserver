using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace KeyCodeReserve
{
    public class ReservedKeyEventRepository
    {

        private static ReservedKeyEventRepository _instance;
        public List<ReservedKeyEvent> KeyEvents = new List<ReservedKeyEvent>();

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



        public void WatchKeyInputOnUpdate()
        {

            for(int i=0; i<Instance.FetchAllKeyEvents().Count; i++)
            {
                if (Input.GetKeyDown(Instance.FetchAllKeyEvents()[i].key))
                {
                    Instance.FetchAllKeyEvents()[i].InvokeKeyEvent();
                }
            }
        }


        public List<ReservedKeyEvent> FetchAllKeyEvents()
        {
            return Instance.KeyEvents;
        }

        public List<ReservedKeyEvent> FetchByKeyCode(KeyCode keyCode)
        {
            List<ReservedKeyEvent> returnKeyEventList = new List<ReservedKeyEvent>();
            foreach (var keyEvent in Instance.KeyEvents)
            {
                if (keyEvent.key == keyCode)
                {
                    returnKeyEventList.Add(keyEvent);
                }
            }

            return returnKeyEventList;
        }
    }
}
