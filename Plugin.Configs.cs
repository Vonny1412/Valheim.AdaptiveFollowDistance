using BepInEx.Configuration;

namespace AdaptiveFollowDistance
{
    public sealed partial class Plugin
    {
        public class Configs
        {

            private const string Section_General = "General";

            public static ConfigEntry<float> FollowColliderRadiusFactor { get; private set; }
            public static ConfigEntry<float> FollowMinDistanceMin { get; private set; }
            public static ConfigEntry<float> FollowMinDistanceMax { get; private set; }
            public static ConfigEntry<float> FollowRunDistanceFactor { get; private set; }

            public static void Initialize(ConfigFile Config)
            {
                string section = "";

                section = Section_General;

                FollowColliderRadiusFactor = Config.Bind<float>(section, "ColliderRadiusFactor", 5f, new ConfigDescription("Multiplier applied to a creature's collider radius to calculate its minimum follow distance.", new AcceptableValueRange<float>(0f, 20f)));
                FollowMinDistanceMin = Config.Bind<float>(section, "MinDistanceMin", 3f, new ConfigDescription("Lower limit for the minimum distance a creature maintains from its follow target.", new AcceptableValueRange<float>(0f, 100f)));
                FollowMinDistanceMax = Config.Bind<float>(section, "MinDistanceMax", 10f, new ConfigDescription("Upper limit for the minimum distance a creature maintains from its follow target.", new AcceptableValueRange<float>(0f, 100f)));
                FollowRunDistanceFactor = Config.Bind<float>(section, "RunDistanceFactor", 3f, new ConfigDescription("Multiplier applied to the minimum follow distance to determine when a creature starts running instead of walking.", new AcceptableValueRange<float>(1f, 20f)));

            }
        }
    }
}
