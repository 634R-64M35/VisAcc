using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.EquipType;

namespace VisAcc {
    public class VisAcc : Mod {
        // Thanks to Antirhinnum for optimizing and fixing a lot of code here

        private void EquipTexture(string texName, EquipType typeSlot, string itemName) =>
            EquipLoader.AddEquipTexture(this, "VisAcc/Textures/" + texName, typeSlot, name: itemName);

        private void ArmorIDsSettings(string equipName, int slotType) {
            // 0 is for the Back and DrawInBackpackLayer
            // 1 is for the Face and DrawInFaceHeadLayer, 2 is for DrawInFaceFlowerLayer, 3 for PreventHairDraw
            switch (slotType) {
                case 0:
                    ArmorIDs.Back.Sets.DrawInBackpackLayer[EquipLoader.GetEquipSlot(this, equipName, Back)] = true;
                    break;

                case 1:
                    ArmorIDs.Face.Sets.DrawInFaceHeadLayer[EquipLoader.GetEquipSlot(this, equipName, Face)] = true;
                    break;

                case 2:
                    ArmorIDs.Face.Sets.DrawInFaceFlowerLayer[EquipLoader.GetEquipSlot(this, equipName, Face)] = true;
                    break;

                case 3:
                    ArmorIDs.Face.Sets.PreventHairDraw[EquipLoader.GetEquipSlot(this, equipName, Face)] = true;
                    break;
            }

        }

        public override void Load() {
            #region Movement
            EquipTexture("Aglet", Shoes, "eAglet");
            EquipTexture("AnkletOfTheWind", Shoes, "eAnklet");
            EquipTexture("LavaCharm", Shield, "eLavaCharm");
            EquipTexture("LuckyHorseshoe", Shoes, "eLuckyHonse");
            EquipTexture("MoltenCharm", Shield, "eMoltCharm");
            EquipTexture("NeptunesShell", Shield, "eNepShell");
            EquipTexture("ObsidianHorseshoe", Shoes, "eObsHonse");
            #endregion

            #region Informational
            EquipTexture("DepthMeter", Waist, "eDepth");
            EquipTexture("Compass", Waist, "eCompass");
            EquipTexture("Radar", Face, "eRadar");
            EquipTexture("LifeformAnalyzer", Back, "eLifeAnalyzer");
            EquipTexture("TallyCounter", Waist, "eTally");
            EquipTexture("MetalDetector", Waist, "eMetal");
            EquipTexture("Stopwatch", Waist, "eStopwatch");
            EquipTexture("DPSMeter", Front, "eDPS");
            EquipTexture("FishermansPocketGuide", Waist, "eFishGuide");
            EquipTexture("WeatherRadio", Beard, "eRadio");
            EquipTexture("Sextant", Shield, "eSextant");
            EquipTexture("GPS", Face, "eGPS");
            EquipTexture("REK3000", Face, "eREK");
            EquipTexture("GoblinTech", Front, "eGoblin");
            EquipTexture("FishFinder", Face, "eFishFinder");
            EquipTexture("PDA", Waist, "ePDA");
            EquipTexture("MechanicalLens", Face, "eLens");
            EquipTexture("MechanicalRuler", Waist, "eMechRuler");
            #endregion

            #region Health and Mana
            EquipTexture("CelestialMagnet", Waist, "eCelMagnet");
            EquipTexture("CelestialEmblem", Waist, "eCelEmblem");
            EquipTexture("MagnetFlower", Waist, "eMagnetFlower");
            EquipTexture("PhilosophersStone", Neck, "ePhilStone");
            #endregion

            #region Combat
            EquipTexture("AdhesiveBandage", Face, "eAdhBandage");
            EquipTexture("AnkhCharm", Waist, "eAnkh");
            EquipTexture("ArmorBracingChest", Neck, "eBracingChest");
            EquipTexture("ArmorBracingPads", HandsOn, "eBracingPads");
            EquipTexture("AvengerEmblem", Neck, "eAvenger");
            EquipTexture("Bezoar", HandsOn, "eBezoar");
            EquipTexture("MoonCharm", Neck, "eMoonCharm");
            EquipTexture("MoonShell", Neck, "eMoonShell");
            EquipTexture("CelestialStone", Neck, "eCelStone");
            EquipTexture("CelestialShell", Neck, "eCelShell");
            EquipTexture("CountercurseMantra", Shield, "eMantra");
            EquipTexture("DestroyerEmblem", Neck, "eDestroy");
            EquipTexture("EyeoftheGolem", Face, "eGolem");
            EquipTexture("FastClock", Waist, "eFastClock");
            EquipTexture("FleshKnucklesHandsOn", HandsOn, "eFleshOn");
            EquipTexture("FleshKnucklesHandsOff", HandsOff, "eFleshOff");
            EquipTexture("HoneyComb", Neck, "eComb");
            EquipTexture("MagmaStone", Neck, "eMagmaStone");
            EquipTexture("MedicatedBandage", Face, "eMedBandage");
            EquipTexture("Megaphone", Face, "eMegaphone");
            EquipTexture("Nazar", Neck, "eNazar");
            EquipTexture("PocketMirror", Waist, "eMirror");
            EquipTexture("PutridScent", Waist, "eScent");
            EquipTexture("RangerEmblem", Neck, "eRanger");
            EquipTexture("ReconScope", Back, "eRecon");
            EquipTexture("RifleScope", Back, "eRifle");
            EquipTexture("SniperScope", Back, "eSniper");
            EquipTexture("SorcererEmblem", Neck, "eSorcerer");
            EquipTexture("SummonerEmblem", Neck, "eSummoner");
            EquipTexture("ThePlan", Waist, "ePlan");
            EquipTexture("TrifoldMap", Waist, "eMap");
            EquipTexture("WarriorEmblem", Neck, "eWarrior");
            EquipTexture("Vitamins", Waist, "eVitamins");
            EquipTexture("HerculesBeetle", Neck, "eBeetle");
            EquipTexture("NecromanticScroll", Waist, "eScroll");
            EquipTexture("PapyrusScarab", Waist, "eScarab");
            #endregion

            #region Construction
            EquipTexture("PortableCementMixer", Back, "eCement");
            EquipTexture("AncientChisel", Shield, "eChisel");
            EquipTexture("ToolBox", Waist, "eBox");
            EquipTexture("PaintSprayer", Waist, "eSpray");
            EquipTexture("ExtendoGrip", HandsOn, "eGrip");
            EquipTexture("BrickLayer", Waist, "eLayer");
            EquipTexture("Presserator", HandsOn, "ePress");
            #endregion

            #region Fishing
            EquipTexture("AnglerEarring", Face, "eEarring");
            EquipTexture("TackleBox", Waist, "eTackle");
            #endregion

            #region Miscellaneous
            EquipTexture("YoyoBag", Waist, "eYoyoBag");
            EquipTexture("ClothierVoodooDoll", Waist, "eClothier");
            EquipTexture("CoinRing", HandsOn, "eCoin");
            EquipTexture("GoldRing", HandsOn, "eGold");
            EquipTexture("GreedyRing", HandsOn, "eGreedy");
            EquipTexture("GregBook", Waist, "eCordage");
            EquipTexture("GuideVoodooDoll", Waist, "eGuide");
            EquipTexture("RadioThing", Face, "eThing");
            EquipTexture("DiscountCard", Waist, "eCard");
            EquipTexture("LuckyCoin", Neck, "eLuckCoin");
            #endregion

            #region Golf Balls
            EquipTexture("GolfBallWhite", Face, "eWhite");
            EquipTexture("GolfBallBlack", Face, "eBlack");
            EquipTexture("GolfBallBlue", Face, "eBlue");
            EquipTexture("GolfBallBrown", Face, "eBrown");
            EquipTexture("GolfBallCyan", Face, "eCyan");
            EquipTexture("GolfBallGreen", Face, "eGreen");
            EquipTexture("GolfBallLime", Face, "eLime");
            EquipTexture("GolfBallOrange", Face, "eOrange");
            EquipTexture("GolfBallPink", Face, "ePink");
            EquipTexture("GolfBallPurple", Face, "ePurple");
            EquipTexture("GolfBallRed", Face, "eRed");
            EquipTexture("GolfBallSkyBlue", Face, "eSkyBlue");
            EquipTexture("GolfBallTeal", Face, "eTeal");
            EquipTexture("GolfBallViolet", Face, "eViolet");
            EquipTexture("GolfBallYellow", Face, "eYellow");
            #endregion

            #region Expert
            EquipTexture("RoyalGel", Face, "eRoyal");
            EquipTexture("BrainOfConfusion", Face, "eBrain");
            EquipTexture("VolatileGelatin", Face, "eVolatile");
            EquipTexture("SporeSacAlt", Face, "eSac");
            EquipTexture("ShinyStone", Neck, "eShiny");
            EquipTexture("SoaringInsignia", Neck, "eSoar");
            EquipTexture("GravityGlobe", Face, "eGravity");
            #endregion

            // Make Armor Polish act like a dye to allow the player to polish their armor
            GameShaders.Armor.BindShader(ItemID.ArmorPolish,
                new ArmorShaderData(new Ref<Effect>(Assets.Request<Effect>("Effects/ArmorPolishShader", AssetRequestMode.ImmediateLoad).Value),
                "ArmorPolishShaderPass")).UseColor(0.65f, 0.65f, 0.65f);

            if (Main.netMode == NetmodeID.Server)
                return;
        }

        public override void PostSetupContent() {
            // Set ArmorIDs sets for the added equips
            if (!Main.dedServ) {
                #region Back
                ArmorIDsSettings("eRecon", 0);
                ArmorIDsSettings("eRifle", 0);
                ArmorIDsSettings("eSniper", 0);
                ArmorIDsSettings("eCement", 0);
                #endregion

                #region Face
                ArmorIDsSettings("eMegaphone", 3);
                ArmorIDsSettings("eRoyal", 3);
                ArmorIDsSettings("eVolatile", 3);

                ArmorIDsSettings("eWhite", 2);
                ArmorIDsSettings("eBlack", 2);
                ArmorIDsSettings("eBlue", 2);
                ArmorIDsSettings("eBrown", 2);
                ArmorIDsSettings("eCyan", 2);
                ArmorIDsSettings("eGreen", 2);
                ArmorIDsSettings("eLime", 2);
                ArmorIDsSettings("eOrange", 2);
                ArmorIDsSettings("ePink", 2);
                ArmorIDsSettings("ePurple", 2);
                ArmorIDsSettings("eRed", 2);
                ArmorIDsSettings("eSkyBlue", 2);
                ArmorIDsSettings("eTeal", 2);
                ArmorIDsSettings("eViolet", 2);
                ArmorIDsSettings("eYellow", 2);
                ArmorIDsSettings("eSac", 2);

                ArmorIDsSettings("eBrain", 3);
                ArmorIDsSettings("eGravity", 3);
                #endregion
            }
        }
    }
}