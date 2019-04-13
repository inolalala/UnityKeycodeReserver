using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace KeyCodeReserve
{
    [System.Serializable]
    public class ConfigCreator : ScriptableObject
    {

        [SerializeField] private string _path = "Assets/Configs";
        [SerializeField] private string _configName;

        public ConfigCreator(string path, string configName)
        {
            _path = path;
            _configName = configName;
        }

        public void Create()
        {
            var config = CreateInstance<KeyEventConfig>();

            AssetDatabase.CreateAsset(config, _path + "/" + _configName + ".asset");
            
        }
    }
}
