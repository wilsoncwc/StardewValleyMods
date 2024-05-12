using HarmonyLib;
using StardewModdingAPI;
using StardewValley.Locations;

namespace YourProjectName
{
    /// <summary>The mod entry point.</summary>
    internal sealed class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            var harmony = new Harmony(this.ModManifest.UniqueID);
            harmony.Patch(
                original: AccessTools.Method(typeof(IslandWest),  "CanPlantSeedsHere"),
                prefix: new HarmonyMethod(typeof(IslandPotFix.IslandWest_CanPlantSeedsHere_Patch), "Prefix")
            );
        }

    }
}