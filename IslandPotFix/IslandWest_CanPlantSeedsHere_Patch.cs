using StardewValley.Locations;

namespace IslandPotFix
{
    /// <summary>
    /// Provides a Harmony patch for the CanPlantSeedsHere method in the IslandWest class.
    /// </summary>
    public class IslandWest_CanPlantSeedsHere_Patch
    {
        /// <summary>
        /// Prefix patch for the CanPlantSeedsHere method.
        /// </summary>
        /// <param name="__result">The result of the CanPlantSeedsHere method.</param>
        /// <param name="itemId">The qualified or unqualified item ID for the seed being planted.</param>
	    /// <param name="tileX">The X tile position for which to apply location-specific overrides.</param>
	    /// <param name="tileY">The Y tile position for which to apply location-specific overrides.</param>
	    /// <param name="isGardenPot">Whether the item is being planted in a garden pot.</param>
	    /// <param name="deniedMessage">The translated message to show to the user indicating why it can't be planted, if applicable.</param>
        ///  <param name="__instance">The instance of the IslandWest class.</param>
        /// <returns>False to skip the original method.</returns>
        public static bool Prefix(ref bool __result, string itemId, int tileX, int tileY, bool isGardenPot, out string deniedMessage, IslandWest __instance)
        {
            __result = __instance.CheckItemPlantRules(itemId, isGardenPot, __instance.GetData()?.CanPlantHere ?? __instance.IsFarm, out deniedMessage);
            return false; // Skip original method
        }
    }
}