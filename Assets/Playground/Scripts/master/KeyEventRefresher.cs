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
        [SerializeField]
        private int TargetIndex;

        private ReservedKeyEventRepository reservedKeyEventRepository;


        public void RefreshAll()
        {
            ReservedKeyEventRepository.Instance.KeyEvents.Clear();
        }
        public void RefreshByKeyCode()
        {
            reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
            reservedKeyEventRepository.KeyEvents.RemoveAll(
                t => t.key == TargetKeycode
            );
        }
        public void RefreshByIndex()
        {
            try
            {
                reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
                reservedKeyEventRepository.KeyEvents.RemoveAt(TargetIndex);
                
            }
            catch(System.NullReferenceException e)
            {
                Debug.Log(e.ToString());
            }
        }
    }
}
