#if BEPINEX
using BepInEx;
using UnityEngine.SceneManagement;

namespace TemplateMod {
    [BepInPlugin("com.github.Kaden5480.poy-template-mod", "Template Mod", PluginInfo.PLUGIN_VERSION)]
    internal class Plugin : BaseUnityPlugin {
        /**
         * <summary>
         * Executes when the plugin is being loaded.
         * </summary>
         */
        private void Awake() {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;

            CommonAwake();
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
            CommonSceneLoad(scene.buildIndex, scene.name);
        }

        /**
         * <summary>
         * Executes when a scene was unloaded.
         * </summary>
         * <param name="scene">The scene which unloaded</param>
         */
        private void OnSceneUnloaded(Scene scene) {
            CommonSceneUnload(scene.buildIndex, scene.name);
        }

        /**
         * <summary>
         * Executes each frame.
         * </summary>
         */
        private void Update() {
            CommonUpdate();
        }

        /**
         * <summary>
         * Executes to render a UI.
         * </summary>
         */
        private void OnGUI() {
            CommonGUI();
        }

#elif MELONLOADER
using MelonLoader;

[assembly: MelonInfo(typeof(TemplateMod.Plugin), "Template Mod", TemplateMod.PluginInfo.PLUGIN_VERSION, "Kaden5480")]
[assembly: MelonGame("TraipseWare", "Peaks of Yore")]

namespace TemplateMod {
    public class Plugin : MelonMod {
        /**
         * <summary>
         * Executes when the mod is being loaded.
         * </summary>
         */
        public override void OnInitializeMelon() {
            CommonAwake();
        }

        /**
         * <summary>
         * Executes when a scene was loaded.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        public override void OnSceneWasLoaded(int buildIndex, string sceneName) {
            CommonSceneLoad(buildIndex, sceneName);
        }

        /**
         * <summary>
         * Executes when a scene was unloaded.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName) {
            CommonSceneLoad(buildIndex, sceneName);
        }

        /**
         * <summary>
         * Executes each frame.
         * </summary>
         */
        public override void OnUpdate() {
            CommonUpdate();
        }

        /**
         * <summary>
         * Executes to render a UI.
         * </summary>
         */
        public override void OnGUI() {
            CommonGUI();
        }

#endif

        /**
         * <summary>
         * Common code to execute when the plugin/mod is being loaded.
         * </summary>
         */
        private void CommonAwake() {
        }

        /**
         * <summary>
         * Common code to execute when a scene was loaded.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        private void CommonSceneLoad(int buildIndex, string sceneName) {
        }

        /**
         * <summary>
         * Common code to execute when a scene was unloaded.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        private void CommonSceneUnload(int buildIndex, string sceneName) {
        }

        /**
         * <summary>
         * Common code to execute each frame.
         * </summary>
         */
        private void CommonUpdate() {
        }

        /**
         * <summary>
         * Common code to render a UI.
         * </summary>
         */
        private void CommonGUI() {
        }
    }
}
