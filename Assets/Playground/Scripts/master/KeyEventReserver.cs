using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeyCodeReserve
{
    [ExecuteInEditMode]
    public class KeyEventReserver : MonoBehaviour
    {

        [SerializeField]
        private List<ReservedKeyEvent> TargetKeyEvents = new List<ReservedKeyEvent>();

        private ReservedKeyEventRepository reservedKeyEventRepository;

        void Awake()
        {
            reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
            Reserve();
        }

        public void Reserve()
        {
            ReservedKeyEventRepository.Instance.KeyEvents.AddRange(TargetKeyEvents);
        }
    }

}