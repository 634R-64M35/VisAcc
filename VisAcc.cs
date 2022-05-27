using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VisAcc {
	public class VisAcc : Mod {
        public static VisAcc instance;
        public static string currentDate;
        public static int day;
        public static int month;
        public override void Load() {
            if (Main.netMode != NetmodeID.Server) {
                //Movement
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Aglet", EquipType.Shoes, name: "EquipAglet");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/AnkletOfTheWind", EquipType.Shoes, name : "EquipAnklet");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/LavaCharm", EquipType.Shield, name: "EquipLavaCharm");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/LuckyHorseshoe", EquipType.Shoes, name: "EquipLuckyHonse");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MoltenCharm", EquipType.Shield, name: "EquipMoltCharm");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/NeptunesShell", EquipType.Shield, name: "EquipNepShell");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ObsidianHorseshoe", EquipType.Shoes, name: "EquipObsHonse");
                //Informational
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/DepthMeter", EquipType.Waist, name: "EquipDepth");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Compass", EquipType.Waist, name: "EquipCompass");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Radar", EquipType.Face, name: "EquipRadar");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/LifeformAnalyzer", EquipType.Back, name: "EquipLifeAnalyzer");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/TallyCounter", EquipType.Waist, name: "EquipTally");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MetalDetector", EquipType.Waist, name: "EquipMetal");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Stopwatch", EquipType.Waist, name: "EquipStopwatch");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/DPSMeter", EquipType.Front, name: "EquipDPS");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/FishermansPocketGuide", EquipType.Waist, name: "EquipFishGuide");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/WeatherRadio", EquipType.Beard, name: "EquipRadio");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Sextant", EquipType.Shield, name: "EquipSextant");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GPS", EquipType.Face, name: "EquipGPS");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/REK3000", EquipType.Face, name: "EquipREK");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GoblinTech", EquipType.Front, name: "EquipGoblin");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/FishFinder", EquipType.Face, name: "EquipFishFinder");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/PDA", EquipType.Waist, name: "EquipPDA");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MechanicalLens", EquipType.Face, name: "EquipLens");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MechanicalRuler", EquipType.Waist, name: "EquipMechRuler");
                //Health and Mana
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/CelestialMagnet", EquipType.Waist, name: "EquipCelMagnet");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/CelestialEmblem", EquipType.Waist, name: "EquipCelEmblem");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MagnetFlower", EquipType.Waist, name: "EquipMagnetFlower");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/PhilosophersStone", EquipType.Neck, name: "EquipPhilStone");
                //Combat
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/AdhesiveBandage", EquipType.Face, name: "EquipAdhBandage");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/AnkhCharm", EquipType.Waist, name: "EquipAnkh");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ArmorBracing", EquipType.Shield, name: "EquipBracing");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/AvengerEmblem", EquipType.Neck, name: "EquipAvenger");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Bezoar", EquipType.HandsOn, name: "EquipBezoar");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MoonCharm", EquipType.Neck, name: "EquipMoonCharm");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MoonShell", EquipType.Neck, name: "EquipMoonShell");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/CelestialStone", EquipType.Neck, name: "EquipCelStone");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/CelestialShell", EquipType.Neck, name: "EquipCelShell");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/CountercurseMantra", EquipType.Shield, name: "EquipMantra");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/DestroyerEmblem", EquipType.Neck, name: "EquipDestroy");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/EyeoftheGolem", EquipType.Face, name: "EquipGolem");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/FastClock", EquipType.Waist, name: "EquipFastClock");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/FleshKnucklesHandsOn", EquipType.HandsOn, name: "EquipFleshOn");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/FleshKnucklesHandsOff", EquipType.HandsOff, name: "EquipFleshOff");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/HoneyComb", EquipType.Neck, name: "EquipComb");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MagmaStone", EquipType.Neck, name: "EquipMagmaStone");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MedicatedBandage", EquipType.Face, name: "EquipMedBandage");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Megaphone", EquipType.Face, name: "EquipMegaphone");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Nazar", EquipType.Neck, name: "EquipNazar");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/PocketMirror", EquipType.Waist, name: "EquipMirror");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/PutridScent", EquipType.Waist, name: "EquipScent");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/RangerEmblem", EquipType.Neck, name: "EquipRanger");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ReconScope", EquipType.Back, name: "EquipRecon");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/RifleScope", EquipType.Back, name: "EquipRifle");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/SniperScope", EquipType.Back, name: "EquipSniper");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/SorcererEmblem", EquipType.Neck, name: "EquipSorcerer");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/SummonerEmblem", EquipType.Neck, name: "EquipSummoner");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ThePlan", EquipType.Waist, name: "EquipPlan");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/TrifoldMap", EquipType.Waist, name: "EquipMap");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/WarriorEmblem", EquipType.Neck, name: "EquipWarrior");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Vitamins", EquipType.Waist, name: "EquipVitamins");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/HerculesBeetle", EquipType.Waist, name: "EquipBeetle");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/NecromanticScroll", EquipType.Waist, name: "EquipScroll");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/PapyrusScarab", EquipType.Waist, name: "EquipScarab");
                //Construction
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/PortableCementMixer", EquipType.Back, name: "EquipCement");
                //Fishing
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/AnglerEarring", EquipType.Face, name: "EquipEarring");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/TackleBox", EquipType.Waist, name: "EquipTackle");
                //Yoyos
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/YoyoBag", EquipType.Waist, name: "EquipYoyoBag");
                //Miscellaneous
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ClothierVoodooDoll", EquipType.Waist, name: "EquipClothier");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/CoinRing", EquipType.HandsOn, name: "EquipCoin");
                //EquipLoader.AddEquipTexture(this, "VisAcc/Textures/DiscountCard", EquipType.Waist, name: "EquipCard");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GoldRing", EquipType.HandsOn, name: "EquipGold");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GreedyRing", EquipType.HandsOn, name: "EquipGreedy");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GregBook", EquipType.Waist, name: "EquipCordage");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GuideVoodooDoll", EquipType.Waist, name: "EquipGuide");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/RadioThing", EquipType.Face, name: "EquipThing");
                //Golf Balls
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallWhite", EquipType.Face, name: "EquipWhite");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallBlack", EquipType.Face, name: "EquipBlack");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallBlue", EquipType.Face, name: "EquipBlue");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallBrown", EquipType.Face, name: "EquipBrown");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallCyan", EquipType.Face, name: "EquipCyan");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallGreen", EquipType.Face, name: "EquipGreen");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallLime", EquipType.Face, name: "EquipLime");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallOrange", EquipType.Face, name: "EquipOrange");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallPink", EquipType.Face, name: "EquipPink");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallPurple", EquipType.Face, name: "EquipPurple");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallRed", EquipType.Face, name: "EquipRed");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallSkyBlue", EquipType.Face, name: "EquipSkyBlue");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallTeal", EquipType.Face, name: "EquipTeal");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallViolet", EquipType.Face, name: "EquipViolet");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GolfBallYellow", EquipType.Face, name: "EquipYellow");
                //Expert
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/RoyalGel", EquipType.Face, name: "EquipRoyal");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/BrainOfConfusion", EquipType.Face, name: "EquipBrain");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/VolatileGelatin", EquipType.Face, name: "EquipVolatile");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/SporeSac", EquipType.Face, name: "EquipSac");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ShinyStone", EquipType.Neck, name: "EquipShiny");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/SoaringInsignia", EquipType.Neck, name: "EquipSoar");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GravityGlobe", EquipType.Face, name: "EquipGravity");
            }

            DateTime dateTime = DateTime.Now;
            currentDate = dateTime.ToString("dd/MM/yyyy");
            day = dateTime.Day;
            month = dateTime.Month;
        }

        public override void Unload() {
            instance = null;
        }
    }
}