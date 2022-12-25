using RimWorld;
using Verse;

namespace PAF.CompProperties
{
    public class PowerArmor : CompProperties_Reloadable
    {
        public ThingDef poweredDef;
        public ThingDef unpoweredDef;
        public string signal_empty = "RanOutOfFuel";
        public string signal_filled = "Refueled";
        public PowerArmor() => compClass = typeof(PAF.ThingComp.PowerArmor);

    }
}