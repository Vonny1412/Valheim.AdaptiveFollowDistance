using HarmonyLib;

namespace AdaptiveFollowDistance.Patches
{
    [HarmonyPatch(typeof(ZNetScene), "Shutdown")]
    static class ZNetScene_Shutdown_Patch
    {
        [HarmonyPrefix]
        private static void Prefix()
        {
            BaseAI_Follow_Patch.Clear();
        }
    }
}
