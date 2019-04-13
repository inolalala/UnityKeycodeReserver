using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeyCodeReserve
{
    [System.Serializable]
    [ExecuteInEditMode]
    public class ConfigReserver : IReservable
    {

        private string _path;

        [SerializeField] private ReservedKeyEvent KeyEvent;

        public ConfigReserver(string path)
        {
            _path = path;
        }

        public void Reserve()
        {
            
        }
    }
}
