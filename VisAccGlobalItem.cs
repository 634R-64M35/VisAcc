using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VisAcc {
    public class VisAccGlobalItem : GlobalItem {
        public override void SetDefaults(Item item)  {
            // By setting the item's [x]slot fields, the equips are automatically added to the player and follow normal equip logic.
            switch (item.type) {
                #region Movement

                case ItemID.Aglet:
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAglet", EquipType.Shoes);
                    break;

                case ItemID.AnkletoftheWind:
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAnklet", EquipType.Shoes);
                    break;

                case ItemID.LavaCharm:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLavaCharm", EquipType.Shield);
                    break;

                case ItemID.LuckyHorseshoe:
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLuckyHonse", EquipType.Shoes);
                    break;

                case ItemID.MoltenCharm:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoltCharm", EquipType.Shield);
                    break;

                case ItemID.NeptunesShell:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipNepShell", EquipType.Shield);
                    break;

                case ItemID.ObsidianHorseshoe:
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipObsHonse", EquipType.Shoes);
                    break;

                #endregion Movement

                #region Informational

                case ItemID.DepthMeter:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDepth", EquipType.Waist);
                    break;

                case ItemID.Compass:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCompass", EquipType.Waist);
                    break;

                case ItemID.Radar:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRadar", EquipType.Face);
                    break;

                case ItemID.LifeformAnalyzer:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLifeAnalyzer", EquipType.Back);
                    break;

                case ItemID.TallyCounter:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipTally", EquipType.Waist);
                    break;

                case ItemID.MetalDetector:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMetal", EquipType.Waist);
                    break;

                case ItemID.Stopwatch:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipStopwatch", EquipType.Waist);
                    break;

                case ItemID.DPSMeter:
                    item.frontSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDPS", EquipType.Front);
                    break;

                case ItemID.FishermansGuide:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFishGuide", EquipType.Waist);
                    break;

                case ItemID.WeatherRadio:
                    item.beardSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRadio", EquipType.Beard);
                    break;

                case ItemID.Sextant:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSextant", EquipType.Shield);
                    break;

                case ItemID.GPS:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGPS", EquipType.Face);
                    break;

                case ItemID.REK:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipREK", EquipType.Face);
                    break;

                case ItemID.GoblinTech:
                    item.frontSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGoblin", EquipType.Front);
                    break;

                case ItemID.FishFinder:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFishFinder", EquipType.Face);
                    break;

                case ItemID.PDA:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPDA", EquipType.Waist);
                    break;

                case ItemID.MechanicalLens:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLens", EquipType.Face);
                    break;

                case ItemID.LaserRuler:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMechRuler", EquipType.Waist);
                    break;

                #endregion Informational

                #region Health and Mana

                case ItemID.CelestialMagnet:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelMagnet", EquipType.Waist);
                    break;

                case ItemID.CelestialEmblem:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelEmblem", EquipType.Waist);
                    break;

                case ItemID.MagnetFlower:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMagnetFlower", EquipType.Waist);
                    break;

                case ItemID.PhilosophersStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPhilStone", EquipType.Neck);
                    break;

                #endregion Health and Mana

                #region Combat

                case ItemID.AdhesiveBandage:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAdhBandage", EquipType.Face);
                    break;

                case ItemID.AnkhCharm:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAnkh", EquipType.Waist);
                    break;

                case ItemID.ArmorBracing:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBracingChest", EquipType.Neck);
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBracingPads", EquipType.HandsOn);
                    break;

                case ItemID.AvengerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAvenger", EquipType.Neck);
                    break;

                case ItemID.Bezoar:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBezoar", EquipType.HandsOn);
                    break;

                case ItemID.MoonCharm:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoonCharm", EquipType.Neck);
                    break;

                case ItemID.MoonShell:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoonShell", EquipType.Neck);
                    break;

                case ItemID.CelestialStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelStone", EquipType.Neck);
                    break;

                case ItemID.CelestialShell:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCelShell", EquipType.Neck);
                    break;

                case ItemID.CountercurseMantra:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMantra", EquipType.Shield);
                    break;

                case ItemID.DestroyerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipDestroy", EquipType.Neck);
                    break;

                case ItemID.EyeoftheGolem:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGolem", EquipType.Face);
                    break;

                case ItemID.FastClock:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFastClock", EquipType.Waist);
                    break;

                case ItemID.FleshKnuckles:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFleshOn", EquipType.HandsOn);
                    item.handOffSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipFleshOff", EquipType.HandsOff);
                    break;

                case ItemID.HoneyComb:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipComb", EquipType.Neck);
                    break;

                case ItemID.MagmaStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMagmaStone", EquipType.Neck);
                    break;

                case ItemID.MedicatedBandage:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMedBandage", EquipType.Face);
                    break;

                case ItemID.Megaphone:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMegaphone", EquipType.Face);
                    break;

                case ItemID.Nazar:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipNazar", EquipType.Neck);
                    break;

                case ItemID.PocketMirror:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMirror", EquipType.Waist);
                    break;

                case ItemID.PutridScent:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipScent", EquipType.Waist);
                    break;

                case ItemID.RangerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRanger", EquipType.Neck);
                    break;

                case ItemID.ReconScope:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRecon", EquipType.Back);
                    break;

                case ItemID.RifleScope:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRifle", EquipType.Back);
                    break;

                case ItemID.SniperScope:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSniper", EquipType.Back);
                    break;

                case ItemID.SorcererEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSorcerer", EquipType.Neck);
                    break;

                case ItemID.SummonerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSummoner", EquipType.Neck);
                    break;

                case ItemID.ThePlan:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPlan", EquipType.Waist);
                    break;

                case ItemID.TrifoldMap:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMap", EquipType.Waist);
                    break;

                case ItemID.WarriorEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipWarrior", EquipType.Neck);
                    break;

                case ItemID.Vitamins:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipVitamins", EquipType.Waist);
                    break;

                case ItemID.HerculesBeetle:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBeetle", EquipType.Neck);
                    break;

                case ItemID.NecromanticScroll:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipScroll", EquipType.Waist);
                    break;

                case ItemID.PapyrusScarab:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipScarab", EquipType.Waist);
                    break;

                #endregion Combat

                #region Construction

                case ItemID.PortableCementMixer:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCement", EquipType.Back);
                    break;

                case ItemID.AncientChisel:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipChisel", EquipType.Shield);
                    break;

                #endregion Construction

                #region Fishing

                case ItemID.AnglerEarring:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipEarring", EquipType.Face);
                    break;

                case ItemID.TackleBox:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipTackle", EquipType.Waist);
                    break;

                #endregion Fishing

                #region Yoyos

                case ItemID.YoyoBag:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipYoyoBag", EquipType.Waist); ;
                    break;

                #endregion Yoyos

                #region Golf

                case ItemID.GolfBall:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipWhite", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedBlack:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBlack", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedBlue:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBlue", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedBrown:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBrown", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedCyan:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCyan", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedGreen:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGreen", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedLimeGreen:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLime", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedOrange:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipOrange", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedPink:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPink", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedPurple:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipPurple", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedRed:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRed", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedSkyBlue:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSkyBlue", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedTeal:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipTeal", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedViolet:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipViolet", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedYellow:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipYellow", EquipType.Face);
                    break;

                #endregion Golf

                #region Miscellaneous

                case ItemID.ClothierVoodooDoll:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipClothier", EquipType.Waist);
                    break;

                case ItemID.CoinRing:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCoin", EquipType.HandsOn);
                    break;

                case ItemID.GoldRing:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGold", EquipType.HandsOn);
                    break;

                case ItemID.GreedyRing:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGreedy", EquipType.HandsOn);
                    break;

                case ItemID.CordageGuide:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCordage", EquipType.Waist);
                    break;

                case ItemID.GuideVoodooDoll:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGuide", EquipType.Waist);
                    break;

                case ItemID.DontStarveShaderItem:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipThing", EquipType.Face);
                    break;
                /*case ItemID.DiscountCard:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipCard", EquipType.Waist);
                    break;
                */

                #endregion Miscellaneous

                #region Expert

                case ItemID.RoyalGel:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipRoyal", EquipType.Face);
                    break;

                case ItemID.BrainOfConfusion:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipBrain", EquipType.Face);
                    break;

                case ItemID.VolatileGelatin:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipVolatile", EquipType.Face);
                    break;

                case ItemID.SporeSac:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSac", EquipType.Face);
                    break;

                case ItemID.ShinyStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipShiny", EquipType.Neck);
                    break;

                case ItemID.EmpressFlightBooster:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipSoar", EquipType.Neck);
                    break;

                case ItemID.GravityGlobe:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipGravity", EquipType.Face);
                    break;

                    #endregion Expert
            }
        }

        public override void UpdateAccessory(Item item, Player player, bool hideVisual) {
            if (!hideVisual)  {
                UpdateFishingEffects(item, player);
            }
        }

        public override void UpdateVanity(Item item, Player player) {
            UpdateFishingEffects(item, player);
        }

        private static void UpdateFishingEffects(Item item, Player player) {
            VisAccPlayer modPlayer = player.GetModPlayer<VisAccPlayer>();

            if (item.type == ItemID.HighTestFishingLine || item.type == ItemID.AnglerTackleBag) {
                modPlayer.highTest = true;
            }
            if (item.type == ItemID.LavaFishingHook) {
                modPlayer.lavaProof = true;
            }
            if (item.type == ItemID.LavaproofTackleBag)  {
                modPlayer.lavaProof = true;
                modPlayer.highTest = true;
            }
        }
    }
}