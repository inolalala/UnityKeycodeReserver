using UnityEngine;

namespace KeyCodeReserve
{
    [ExecuteInEditMode]
    public class KeyEventConfigurator : ILoadable, IConservable
    {
        private ReservedKeyEventRepository repository;

        public void Load()
        {
            repository = ReservedKeyEventRepository.Instance;

        }
        public void Save()
        {
            repository = ReservedKeyEventRepository.Instance;
            
            // PlayerPrefs.SetString();
        }
    }
}
