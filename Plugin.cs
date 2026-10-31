using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace AdaptiveFollowDistance
{
	public sealed partial class Plugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log { get; private set; }

        private void Awake()
		{
            Log = this.Logger;
            Plugin.Configs.Initialize(Config);
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);

            // todo: config sync
        }

	}
}
