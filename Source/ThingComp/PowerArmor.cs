using RimWorld;
using Verse;

namespace PAF.ThingComp
{
    public class PowerArmor : CompReloadable
    {
        new CompProperties.PowerArmor Props => props as CompProperties.PowerArmor;
        int tick = 0;
        public override void CompTick()
        {
            base.CompTick();

            Apparel powerArmor = parent as Apparel;
            if (powerArmor == null || powerArmor.Wearer == null) return;

            tick++;
            if (tick < 500) return;
            tick = 0;

            if (CanBeUsed)
            {
                SetPowered(true);
                UsedOnce();
            }
            else
                SetPowered(false);
        }
        private void SetPowered(bool powered)
        {
            ThingDef chosenDef = (powered) ? Props.poweredDef : Props.poweredDef;
            if (parent.def != chosenDef)
            {
                parent.def = chosenDef;
            }
        }
    }
}