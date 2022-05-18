using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc
{
    public class VisAccGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            foreach (Item i in player.armor)
            {
                #region //Movement
                if (i.type == ItemID.Aglet)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAglet", EquipType.Shoes);
                }
                if (i.type == ItemID.AnkletoftheWind)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAnklet", EquipType.Shoes);
                }
                if (i.type == ItemID.LavaCharm)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLavaCharm", EquipType.Shield);
                }
                if (i.type == ItemID.LuckyHorseshoe)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLuckyHonse", EquipType.Shoes);
                }
                if (i.type == ItemID.MoltenCharm)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoltCharm", EquipType.Shield);
                }
                if (i.type == ItemID.NeptunesShell)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipNepShell", EquipType.Shield);
                }
                if (i.type == ItemID.ObsidianHorseshoe)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipObsHonse", EquipType.Shoes);
                }
                #endregion

                #region //Informational
                if (i.type == ItemID.DepthMeter)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDepth", EquipType.Waist);
                }
                if (i.type == ItemID.Compass)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCompass", EquipType.Waist);
                }
                if (i.type == ItemID.Radar)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRadar", EquipType.Face);
                }
                if (i.type == ItemID.LifeformAnalyzer)
                {
                    player.back = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLifeAnalyzer", EquipType.Back);
                }
                if (i.type == ItemID.TallyCounter)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipTally", EquipType.Waist);
                }
                if (i.type == ItemID.MetalDetector)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMetal", EquipType.Waist);
                }
                if (i.type == ItemID.Stopwatch)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipStopwatch", EquipType.Waist);
                }
                if (i.type == ItemID.DPSMeter)
                {
                    player.front = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDPS", EquipType.Front);
                }
                if (i.type == ItemID.FishermansGuide)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFishGuide", EquipType.Waist);
                }
                if (i.type == ItemID.WeatherRadio)
                {
                    player.beard = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRadio", EquipType.Beard);
                }
                if (i.type == ItemID.Sextant)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSextant", EquipType.Shield);
                }
                if (i.type == ItemID.GPS)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGPS", EquipType.Face);
                }
                if (i.type == ItemID.REK)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipREK", EquipType.Face);
                }
                if (i.type == ItemID.GoblinTech)
                {
                    player.front = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGoblin", EquipType.Front);
                }
                if (i.type == ItemID.FishFinder)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFishFinder", EquipType.Face);
                }
                if (i.type == ItemID.PDA)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPDA", EquipType.Waist);
                }
                if (i.type == ItemID.MechanicalLens)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLens", EquipType.Face);
                }
                if (i.type == ItemID.LaserRuler)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMechRuler", EquipType.Waist);
                }
                #endregion

                #region //Health and Mana
                if (i.type == ItemID.CelestialMagnet)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelMagnet", EquipType.Waist);
                }
                if (i.type == ItemID.CelestialEmblem)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelEmblem", EquipType.Waist);
                }
                if (i.type == ItemID.MagnetFlower)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMagnetFlower", EquipType.Waist);
                }
                if (i.type == ItemID.PhilosophersStone)
                {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPhilStone", EquipType.Neck);
                }
                #endregion

                #region //Combat
                if (i.type == ItemID.AdhesiveBandage)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAdhBandage", EquipType.Face);
                }
                if (i.type == ItemID.AnkhCharm)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAnkh", EquipType.Waist);
                }
                /*if (i.type == ItemID.ArmorBracing)
                {
                    player.front = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBracing", EquipType.Front);
                }
                if (i.type == ItemID.AvengerEmblem)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAvenger", EquipType.Shield);
                }*/
                if (i.type == ItemID.Bezoar)
                {
                    player.handon = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBezoar", EquipType.HandsOn);
                }
                if (i.type == ItemID.MoonCharm)
                {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoonCharm", EquipType.Neck);
                }
                if (i.type == ItemID.MoonShell)
                {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoonShell", EquipType.Neck);
                }
                /*if (i.type == ItemID.CelestialStone)
                {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelStone", EquipType.Neck);
                }*/
                if (i.type == ItemID.CountercurseMantra)
                {
                    player.shield  = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMantra", EquipType.Shield);
                }
                /*if (i.type == ItemID.DestroyerEmblem)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDestroy", EquipType.Shield);
                }*/
                if (i.type == ItemID.EyeoftheGolem)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGolem", EquipType.Face);
                }
                if (i.type == ItemID.FastClock)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFastClock", EquipType.Waist);
                }
                if (i.type == ItemID.FleshKnuckles)
                {
                    player.handon = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFleshOn", EquipType.HandsOn);
                    player.handoff = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFleshOff", EquipType.HandsOff);
                }
                if (i.type == ItemID.HoneyComb)
                {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipHoneyComb", EquipType.Neck);
                }
                if (i.type == ItemID.MedicatedBandage)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMedBandage", EquipType.Face);
                }
                if (i.type == ItemID.Megaphone)
                {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMegaphone", EquipType.Face);
                }
                if (i.type == ItemID.Nazar)
                {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipNazar", EquipType.Neck);
                }
                #endregion
            }
        }
    }
}