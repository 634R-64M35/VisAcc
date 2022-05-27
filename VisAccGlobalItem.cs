using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc {
    public class VisAccGlobalItem : GlobalItem {
        public override bool InstancePerEntity => true;
        public override void UpdateAccessory(Item item, Player player, bool hideVisual) {
            foreach (Item i in player.armor) {
                #region //Movement
                if (i.type == ItemID.Aglet) {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAglet", EquipType.Shoes);
                }
                if (i.type == ItemID.AnkletoftheWind) {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAnklet", EquipType.Shoes);
                }
                if (i.type == ItemID.LavaCharm) {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLavaCharm", EquipType.Shield);
                }
                if (i.type == ItemID.LuckyHorseshoe) {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLuckyHonse", EquipType.Shoes);
                }
                if (i.type == ItemID.MoltenCharm) {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoltCharm", EquipType.Shield);
                }
                if (i.type == ItemID.NeptunesShell) {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipNepShell", EquipType.Shield);
                }
                if (i.type == ItemID.ObsidianHorseshoe) {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipObsHonse", EquipType.Shoes);
                }
                #endregion

                #region //Informational
                if (i.type == ItemID.DepthMeter) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDepth", EquipType.Waist);
                }
                if (i.type == ItemID.Compass) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCompass", EquipType.Waist);
                }
                if (i.type == ItemID.Radar) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRadar", EquipType.Face);
                }
                if (i.type == ItemID.LifeformAnalyzer) {
                    player.back = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLifeAnalyzer", EquipType.Back);
                }
                if (i.type == ItemID.TallyCounter) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipTally", EquipType.Waist);
                }
                if (i.type == ItemID.MetalDetector) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMetal", EquipType.Waist);
                }
                if (i.type == ItemID.Stopwatch) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipStopwatch", EquipType.Waist);
                }
                if (i.type == ItemID.DPSMeter) {
                    player.front = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDPS", EquipType.Front);
                }
                if (i.type == ItemID.FishermansGuide) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFishGuide", EquipType.Waist);
                }
                if (i.type == ItemID.WeatherRadio) {
                    player.beard = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRadio", EquipType.Beard);
                }
                if (i.type == ItemID.Sextant) {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSextant", EquipType.Shield);
                }
                if (i.type == ItemID.GPS) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGPS", EquipType.Face);
                }
                if (i.type == ItemID.REK) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipREK", EquipType.Face);
                }
                if (i.type == ItemID.GoblinTech) {
                    player.front = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGoblin", EquipType.Front);
                }
                if (i.type == ItemID.FishFinder) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFishFinder", EquipType.Face);
                }
                if (i.type == ItemID.PDA) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPDA", EquipType.Waist);
                }
                if (i.type == ItemID.MechanicalLens) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLens", EquipType.Face);
                }
                if (i.type == ItemID.LaserRuler) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMechRuler", EquipType.Waist);
                }
                #endregion

                #region //Health and Mana
                if (i.type == ItemID.CelestialMagnet) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelMagnet", EquipType.Waist);
                }
                if (i.type == ItemID.CelestialEmblem) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelEmblem", EquipType.Waist);
                }
                if (i.type == ItemID.MagnetFlower) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMagnetFlower", EquipType.Waist);
                }
                if (i.type == ItemID.PhilosophersStone) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPhilStone", EquipType.Neck);
                }
                #endregion

                #region //Combat
                if (i.type == ItemID.AdhesiveBandage) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAdhBandage", EquipType.Face);
                }
                if (i.type == ItemID.AnkhCharm) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAnkh", EquipType.Waist);
                }
                if (i.type == ItemID.ArmorBracing) {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBracing", EquipType.Shield);
                }
                if (i.type == ItemID.AvengerEmblem) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAvenger", EquipType.Neck);
                }
                if (i.type == ItemID.Bezoar) {
                    player.handon = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBezoar", EquipType.HandsOn);
                }
                if (i.type == ItemID.MoonCharm) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoonCharm", EquipType.Neck);
                }
                if (i.type == ItemID.MoonShell) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoonShell", EquipType.Neck);
                }
                if (i.type == ItemID.CelestialStone) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelStone", EquipType.Neck);
                }
                if (i.type == ItemID.CelestialShell) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelShell", EquipType.Neck);
                }
                if (i.type == ItemID.CountercurseMantra) {
                    player.shield  = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMantra", EquipType.Shield);
                }
                if (i.type == ItemID.DestroyerEmblem) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDestroy", EquipType.Neck);
                }
                if (i.type == ItemID.EyeoftheGolem) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGolem", EquipType.Face);
                }
                if (i.type == ItemID.FastClock) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFastClock", EquipType.Waist);
                }
                if (i.type == ItemID.FleshKnuckles) {
                    player.handon = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFleshOn", EquipType.HandsOn);
                    player.handoff = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFleshOff", EquipType.HandsOff);
                }
                if (i.type == ItemID.HoneyComb) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipComb", EquipType.Neck);
                }
                if (i.type == ItemID.MagmaStone)
                {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMagmaStone", EquipType.Neck);
                }
                if (i.type == ItemID.MedicatedBandage) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMedBandage", EquipType.Face);
                }
                if (i.type == ItemID.Megaphone) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMegaphone", EquipType.Face);
                }
                if (i.type == ItemID.Nazar) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipNazar", EquipType.Neck);
                }
                if (i.type == ItemID.PocketMirror) {
                    player.waist  = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMirror", EquipType.Waist);
                }
                if (i.type == ItemID.PutridScent) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipScent", EquipType.Waist);
                }
                if (i.type == ItemID.RangerEmblem) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRanger", EquipType.Neck);
                }
                if (i.type == ItemID.ReconScope) {
                    player.back = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRecon", EquipType.Back);
                }
                if (i.type == ItemID.RifleScope) {
                    player.back = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRifle", EquipType.Back);
                }
                if (i.type == ItemID.SniperScope) {
                    player.back = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSniper", EquipType.Back);
                }
                if (i.type == ItemID.SorcererEmblem) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSorcerer", EquipType.Neck);
                }
                if (i.type == ItemID.SummonerEmblem) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSummoner", EquipType.Neck);
                }
                if (i.type == ItemID.ThePlan) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPlan", EquipType.Waist);
                }
                if (i.type == ItemID.TrifoldMap) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMap", EquipType.Waist);
                }
                if (i.type == ItemID.WarriorEmblem) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipWarrior", EquipType.Neck);
                }
                if (i.type == ItemID.Vitamins) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipVitamins", EquipType.Waist);
                }
                if (i.type == ItemID.HerculesBeetle) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBeetle", EquipType.Waist);
                }
                if (i.type == ItemID.NecromanticScroll) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipScroll", EquipType.Waist);
                }
                if (i.type == ItemID.PapyrusScarab) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipScarab", EquipType.Waist);
                }
                #endregion

                #region //Construction
                if (i.type == ItemID.PortableCementMixer) {
                    player.back = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCement", EquipType.Back);
                }
                #endregion

                #region //Fishing
                if (i.type == ItemID.AnglerEarring) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipEarring", EquipType.Face);
                }
                if (i.type == ItemID.TackleBox) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipTackle", EquipType.Waist);
                }
                #endregion

                #region //Yoyos
                if (i.type == ItemID.YoyoBag) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipYoyoBag", EquipType.Waist);
                }
                #endregion

                #region //Miscellaneous
                if (i.type == ItemID.ClothierVoodooDoll) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipClothier", EquipType.Waist);
                }
                if (i.type == ItemID.CoinRing) {
                    player.handon = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCoin", EquipType.HandsOn);
                }
                /*if (i.type == ItemID.DiscountCard) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCard", EquipType.Waist);
                }*/
                if (i.type == ItemID.GoldRing) {
                    player.handon = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGold", EquipType.HandsOn);
                }
                if (i.type == ItemID.GreedyRing) {
                    player.handon = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGreedy", EquipType.HandsOn);
                }
                if (i.type == ItemID.CordageGuide) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCordage", EquipType.Waist);
                }
                if (i.type == ItemID.GuideVoodooDoll) {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGuide", EquipType.Waist);
                }
                if (i.type == ItemID.DontStarveShaderItem) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipThing", EquipType.Face);
                }
                #endregion

                #region //Golf Balls
                if (i.type == ItemID.GolfBall) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipWhite", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedBlack) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBlack", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedBlue) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBlue", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedBrown) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBrown", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedCyan) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCyan", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedGreen) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGreen", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedLimeGreen) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLime", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedOrange) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipOrange", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedPink) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPink", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedPurple) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPurple", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedRed) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRed", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedSkyBlue) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSkyBlue", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedTeal) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipTeal", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedViolet) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipViolet", EquipType.Face);
                }
                if (i.type == ItemID.GolfBallDyedYellow) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipYellow", EquipType.Face);
                }
                #endregion

                #region //Expert
                if (i.type == ItemID.RoyalGel) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRoyal", EquipType.Face);
                }
                if (i.type == ItemID.BrainOfConfusion) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBrain", EquipType.Face);
                }
                if (i.type == ItemID.VolatileGelatin) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipVolatile", EquipType.Face);
                }
                if (i.type == ItemID.SporeSac) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSac", EquipType.Face);
                }
                if (i.type == ItemID.ShinyStone) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipShiny", EquipType.Neck);
                }
                if (i.type == ItemID.EmpressFlightBooster) {
                    player.neck = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSoar", EquipType.Neck);
                }
                if (i.type == ItemID.GravityGlobe) {
                    player.face = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGravity", EquipType.Face);
                }
                #endregion
            }
        }
    }
}