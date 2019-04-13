using UnityEngine;

namespace KeyCodeReserve
{
    [ExecuteInEditMode]
    public class KeyEventConfigurator : MonoBehaviour
    {

        [SerializeField] private string configPath;
        [SerializeField] private string configName;


        public void CreateConfig()
        {
            ConfigCreator configCreator = new ConfigCreator(configPath, configName);
        }

        [SerializeField] private ConfigReserver configReserver;
        
    }
}
