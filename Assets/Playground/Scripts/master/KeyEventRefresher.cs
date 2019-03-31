using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KeyCodeReserve
{
    [ExecuteInEditMode]
    public class KeyEventRefresher : MonoBehaviour
    {
        [SerializeField]
        private KeyCode TargetKeycode;

        private ReservedKeyEventRepository reservedKeyEventRepository;

        void Awake()
        {
            reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
        }

        public void RefreshAll()
        {
            ReservedKeyEventRepository.Instance.KeyEvents.Clear();
        }
        public void RefreshByKeyCode()
        {
            reservedKeyEventRepository.KeyEvents.RemoveAll(
                t => t.key == TargetKeycode
            );
        }
    }
}
