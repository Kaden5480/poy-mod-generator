using BepInEx;
using UnityEngine.SceneManagement;

namespace TemplateMod {
    [BepInPlugin("com.github.Kaden5480.poy-template-mod", "Template Mod", PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        /**
         * <summary>
         * Executes when the plugin is being loaded.
         * </summary>
         */
        private void Awake() {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;
        }

        /**
         * <summary>
         * Executes when the plugin is being destroyed.
         * </summary>
         */
        private void OnDestroy() {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.sceneUnloaded -= OnSceneUnloaded;
        }

        /**
         * <summary>
         * Executes when a scene was loaded.
         * </summary>
         * <param name="scene">The scene which loaded</param>
         * <param name="mode">The mode the scene was loaded with</param>
         */
        private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        }

        /**
         * <summary>
         * Executes when a scene was unloaded.
         * </summary>
         * <param name="scene">The scene which unloaded</param>
         */
        private void OnSceneUnloaded(Scene scene) {
        }

        /**
         * <summary>
         * Executes each frame.
         * </summary>
         */
        private void Update() {
        }

        /**
         * <summary>
         * Executes to render a UI.
         * </summary>
         */
        private void OnGUI() {
        }
    }
}
