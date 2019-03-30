
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace KeyCodeReserve
{
    public class KeyCodeReserver : MonoBehaviour
    {

        [SerializeField] 
        private List<ReservedKeyEvent> ReserveKeyEvents = new List<ReservedKeyEvent>();



        private ReservedKeyEventRepository reservedKeyEventRepository;

        void Awake()
        {
            reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
            reservedKeyEventRepository.Add(ReserveKeyEvents);
        }


        public void UpdateCurrentKeyEventsList()
        {

        }

    }
}
