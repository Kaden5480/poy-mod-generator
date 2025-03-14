using MelonLoader;

[assembly: MelonInfo(typeof(TemplateMod.Mod), "Template Mod", PluginInfo.PLUGIN_VERSION, "Kaden5480")]
[assembly: MelonGame("TraipseWare", "Peaks of Yore")]

namespace TemplateMod {
    public class Mod : MelonMod {
        /**
         * <summary>
         * Executes when the mod is being loaded.
         * </summary>
         */
        public override void OnInitializeMelon() {
        }

        /**
         * <summary>
         * Executes when a scene was loaded.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        public override void OnSceneWasLoaded(int buildIndex, string sceneName) {
        }

        /**
         * <summary>
         * Executes when a scene was unloaded.
         * </summary>
         * <param name="buildIndex">The build index of the scene</param>
         * <param name="sceneName">The name of the scene</param>
         */
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName) {
        }

        /**
         * <summary>
         * Executes each frame.
         * </summary>
         */
        public override void OnUpdate() {
        }

        /**
         * <summary>
         * Executes to render a UI.
         * </summary>
         */
        public override void OnGUI() {
        }

    }
}
