using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VisAcc
{
	public class VisAcc : Mod
	{
        public static VisAcc instance;

        public static string currentDate;
        public static int day;
        public static int month;


        public override void Load()
        {
            if (Main.netMode != NetmodeID.Server)
            {
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
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/WeatherRadio", EquipType.Face, name: "EquipRadio");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Sextant", EquipType.Shield, name: "EquipSextant");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GPS", EquipType.Face, name: "EquipGPS");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/REK3000", EquipType.Face, name: "EquipREK");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GoblinTech", EquipType.Front, name: "EquipGoblin");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/FishFinder", EquipType.Face, name: "EquipFishFinder");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/PDA", EquipType.Waist, name: "EquipPDA");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MechanicalLens", EquipType.Face, name: "EquipLens");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MechanicalRuler", EquipType.Waist, name: "EquipMechRuler");
            }

            DateTime dateTime = DateTime.Now;
            currentDate = dateTime.ToString("dd/MM/yyyy");
            day = dateTime.Day;
            month = dateTime.Month;
            base.Load();
        }

        public override void Unload()
        {
            instance = null;
        }
    }
}