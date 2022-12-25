using RimWorld;
using Verse;

#pragma warning disable 0649
namespace PAF
{
    [DefOf]
    internal static class ThingDefOf
    {
        public static Verse.ThingDef PAF_Thing_PoweredFrame;
        public static Verse.ThingDef PAF_Thing_UnpoweredFrame;
        static ThingDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(RimWorld.ThingDefOf));
    }
}
#pragma warning restore 0649