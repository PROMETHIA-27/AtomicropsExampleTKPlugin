using BepInEx;
using UnityEditor;

namespace ExampleTKPlugin
{
    [BepInPlugin("com.PROMETHIA.ExampleTKPlugin", "Example TK Plugin", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        internal static BepInEx.Logging.ManualLogSource _log;

        private void Awake()
        {
            // Plugin startup logic
            this.Logger.LogInfo("Plugin com.PROMETHIA.ExampleTKPlugin is loaded!");
            _log = this.Logger;
        }
    }
}

