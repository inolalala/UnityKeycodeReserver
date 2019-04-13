using UnityEngine;
using System.Collections.Generic;

namespace KeyCodeReserve
{
    [System.Serializable]
    public class KeyEventReserver : IReservable
    {
        [SerializeField]
        private ReservedKeyEvent ReserveTarget = new ReservedKeyEvent();

        public void Reserve()
        {
            Debug.Log("Reserve is called");
        }
    }

}