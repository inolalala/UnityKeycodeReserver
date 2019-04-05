using UnityEngine;

namespace KeyCodeReserve
{
    [ExecuteInEditMode]
    public class KeyEventReserver : MonoBehaviour
    {

        [SerializeField]
        private ReservedKeyEvent ReserveTarget = new ReservedKeyEvent();

        private ReservedKeyEventRepository reservedKeyEventRepository;

        void Awake()
        {
            reservedKeyEventRepository = ReservedKeyEventRepository.Instance;
            Reserve();
        }

        public void Reserve()
        {
            Debug.Log("Reserve is called");
            ReservedKeyEventRepository.Instance.KeyEvents.Add(ReserveTarget);

            ReserveTarget = new ReservedKeyEvent();
        }
    }

}