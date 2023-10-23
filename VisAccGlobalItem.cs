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
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eAglet", EquipType.Shoes);
                    break;

                case ItemID.AnkletoftheWind:
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eAnklet", EquipType.Shoes);
                    break;

                case ItemID.LavaCharm:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eLavaCharm", EquipType.Shield);
                    break;

                case ItemID.LuckyHorseshoe:
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eLuckyHonse", EquipType.Shoes);
                    break;

                case ItemID.MoltenCharm:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMoltCharm", EquipType.Shield);
                    break;

                case ItemID.NeptunesShell:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eNepShell", EquipType.Shield);
                    break;

                case ItemID.ObsidianHorseshoe:
                    item.shoeSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eObsHonse", EquipType.Shoes);
                    break;

                #endregion

                #region Informational

                case ItemID.DepthMeter:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eDepth", EquipType.Waist);
                    break;

                case ItemID.Compass:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCompass", EquipType.Waist);
                    break;

                case ItemID.Radar:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eRadar", EquipType.Face);
                    break;

                case ItemID.LifeformAnalyzer:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eLifeAnalyzer", EquipType.Back);
                    break;

                case ItemID.TallyCounter:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eTally", EquipType.Waist);
                    break;

                case ItemID.MetalDetector:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMetal", EquipType.Waist);
                    break;

                case ItemID.Stopwatch:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eStopwatch", EquipType.Waist);
                    break;

                case ItemID.DPSMeter:
                    item.frontSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eDPS", EquipType.Front);
                    break;

                case ItemID.FishermansGuide:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eFishGuide", EquipType.Waist);
                    break;

                case ItemID.WeatherRadio:
                    item.beardSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eRadio", EquipType.Beard);
                    break;

                case ItemID.Sextant:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSextant", EquipType.Shield);
                    break;

                case ItemID.GPS:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGPS", EquipType.Face);
                    break;

                case ItemID.REK:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eREK", EquipType.Face);
                    break;

                case ItemID.GoblinTech:
                    item.frontSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGoblin", EquipType.Front);
                    break;

                case ItemID.FishFinder:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eFishFinder", EquipType.Face);
                    break;

                case ItemID.PDA:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "ePDA", EquipType.Waist);
                    break;

                case ItemID.MechanicalLens:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eLens", EquipType.Face);
                    break;

                case ItemID.LaserRuler:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMechRuler", EquipType.Waist);
                    break;

                #endregion

                #region Health and Mana

                case ItemID.CelestialMagnet:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCelMagnet", EquipType.Waist);
                    break;

                case ItemID.CelestialEmblem:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCelEmblem", EquipType.Waist);
                    break;

                case ItemID.MagnetFlower:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMagnetFlower", EquipType.Waist);
                    break;

                case ItemID.PhilosophersStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "ePhilStone", EquipType.Neck);
                    break;

                #endregion

                #region Combat

                case ItemID.AdhesiveBandage:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eAdhBandage", EquipType.Face);
                    break;

                case ItemID.AnkhCharm:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eAnkh", EquipType.Waist);
                    break;

                case ItemID.ArmorBracing:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBracingChest", EquipType.Neck);
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBracingPads", EquipType.HandsOn);
                    break;

                case ItemID.AvengerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eAvenger", EquipType.Neck);
                    break;

                case ItemID.Bezoar:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBezoar", EquipType.HandsOn);
                    break;

                case ItemID.MoonCharm:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMoonCharm", EquipType.Neck);
                    break;

                case ItemID.MoonShell:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMoonShell", EquipType.Neck);
                    break;

                case ItemID.CelestialStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCelStone", EquipType.Neck);
                    break;

                case ItemID.CelestialShell:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCelShell", EquipType.Neck);
                    break;

                case ItemID.CountercurseMantra:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMantra", EquipType.Shield);
                    break;

                case ItemID.DestroyerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eDestroy", EquipType.Neck);
                    break;

                case ItemID.EyeoftheGolem:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGolem", EquipType.Face);
                    break;

                case ItemID.FastClock:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eFastClock", EquipType.Waist);
                    break;

                case ItemID.FleshKnuckles:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eFleshOn", EquipType.HandsOn);
                    item.handOffSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eFleshOff", EquipType.HandsOff);
                    break;

                case ItemID.HoneyComb:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eComb", EquipType.Neck);
                    break;

                case ItemID.MagmaStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMagmaStone", EquipType.Neck);
                    break;

                case ItemID.MedicatedBandage:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMedBandage", EquipType.Face);
                    break;

                case ItemID.Megaphone:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMegaphone", EquipType.Face);
                    break;

                case ItemID.Nazar:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eNazar", EquipType.Neck);
                    break;

                case ItemID.PocketMirror:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMirror", EquipType.Waist);
                    break;

                case ItemID.PutridScent:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eScent", EquipType.Waist);
                    break;

                case ItemID.RangerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eRanger", EquipType.Neck);
                    break;

                case ItemID.ReconScope:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eRecon", EquipType.Back);
                    break;

                case ItemID.RifleScope:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eRifle", EquipType.Back);
                    break;

                case ItemID.SniperScope:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSniper", EquipType.Back);
                    break;

                case ItemID.SorcererEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSorcerer", EquipType.Neck);
                    break;

                case ItemID.SummonerEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSummoner", EquipType.Neck);
                    break;

                case ItemID.ThePlan:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "ePlan", EquipType.Waist);
                    break;

                case ItemID.TrifoldMap:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eMap", EquipType.Waist);
                    break;

                case ItemID.WarriorEmblem:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eWarrior", EquipType.Neck);
                    break;

                case ItemID.Vitamins:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eVitamins", EquipType.Waist);
                    break;

                case ItemID.HerculesBeetle:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBeetle", EquipType.Neck);
                    break;

                case ItemID.NecromanticScroll:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eScroll", EquipType.Waist);
                    break;

                case ItemID.PapyrusScarab:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eScarab", EquipType.Waist);
                    break;

                #endregion

                #region Construction

                case ItemID.PortableCementMixer:
                    item.backSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCement", EquipType.Back);
                    break;

                case ItemID.AncientChisel:
                    item.shieldSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eChisel", EquipType.Shield);
                    break;

                case ItemID.Toolbox:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBox", EquipType.Waist);
                    break;

                case ItemID.PaintSprayer:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSpray", EquipType.Waist);
                    break;

                case ItemID.ExtendoGrip:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGrip", EquipType.HandsOn);
                    break;

                case ItemID.BrickLayer:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eLayer", EquipType.Waist);
                    break;

                case ItemID.ActuationAccessory:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "ePress", EquipType.HandsOn);
                    break;

                #endregion

                #region Fishing

                case ItemID.AnglerEarring:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eEarring", EquipType.Face);
                    break;

                case ItemID.TackleBox:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eTackle", EquipType.Waist);
                    break;

                #endregion

                #region Yoyos

                case ItemID.YoyoBag:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eYoyoBag", EquipType.Waist); ;
                    break;

                #endregion

                #region Golf

                case ItemID.GolfBall:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eWhite", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedBlack:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBlack", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedBlue:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBlue", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedBrown:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBrown", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedCyan:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCyan", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedGreen:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGreen", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedLimeGreen:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eLime", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedOrange:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eOrange", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedPink:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "ePink", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedPurple:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "ePurple", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedRed:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eRed", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedSkyBlue:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSkyBlue", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedTeal:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eTeal", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedViolet:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eViolet", EquipType.Face);
                    break;

                case ItemID.GolfBallDyedYellow:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eYellow", EquipType.Face);
                    break;

                #endregion

                #region Miscellaneous

                case ItemID.ClothierVoodooDoll:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eClothier", EquipType.Waist);
                    break;

                case ItemID.CoinRing:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCoin", EquipType.HandsOn);
                    break;

                case ItemID.GoldRing:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGold", EquipType.HandsOn);
                    break;

                case ItemID.GreedyRing:
                    item.handOnSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGreedy", EquipType.HandsOn);
                    break;

                case ItemID.CordageGuide:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCordage", EquipType.Waist);
                    break;

                case ItemID.GuideVoodooDoll:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGuide", EquipType.Waist);
                    break;

                case ItemID.DontStarveShaderItem:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eThing", EquipType.Face);
                    break;

                case ItemID.DiscountCard:
                    item.waistSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eCard", EquipType.Waist);
                    break;

                case ItemID.LuckyCoin:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eLuckCoin", EquipType.Neck);
                    break;

                #endregion

                #region Expert

                case ItemID.RoyalGel:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eRoyal", EquipType.Face);
                    break;

                case ItemID.BrainOfConfusion:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eBrain", EquipType.Face);
                    break;

                case ItemID.VolatileGelatin:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eVolatile", EquipType.Face);
                    break;

                case ItemID.SporeSac:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSac", EquipType.Face);
                    break;

                case ItemID.ShinyStone:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eShiny", EquipType.Neck);
                    break;

                case ItemID.EmpressFlightBooster:
                    item.neckSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eSoar", EquipType.Neck);
                    break;

                case ItemID.GravityGlobe:
                    item.faceSlot = (sbyte)EquipLoader.GetEquipSlot(Mod, "eGravity", EquipType.Face);
                    break;

                #endregion
            }
        }

        public override void UpdateAccessory(Item item, Player player, bool hideVisual) {
            if (!hideVisual)
                UpdateFishingEffects(item, player);
        }

        public override void UpdateVanity(Item item, Player player) =>
            UpdateFishingEffects(item, player);

        private static void UpdateFishingEffects(Item item, Player player) {
            VisAccPlayer modPlayer = player.GetModPlayer<VisAccPlayer>();

            if (item.type == ItemID.LavaproofTackleBag || item.type == ItemID.AnglerTackleBag || item.type == ItemID.HighTestFishingLine)
                modPlayer.highTest = true;
            if (item.type == ItemID.LavaproofTackleBag || item.type == ItemID.LavaFishingHook)
                modPlayer.lavaProof = true;
        }
    }
}