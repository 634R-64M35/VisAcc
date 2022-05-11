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
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/AnkletOfTheWind", EquipType.Shoes, name : "EquipAnklet");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/LavaCharm", EquipType.Shield, name: "EquipLavaCharm");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/LuckyHorseshoe", EquipType.Shoes, name: "EquipLuckyHonse");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MoltenCharm", EquipType.Shield, name: "EquipMoltCharm");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/NeptunesShell", EquipType.Shield, name: "EquipNepShell");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ObsidianHorseshoe", EquipType.Shoes, name: "EquipObsHonse");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Aglet", EquipType.Shoes, name: "EquipAglet");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/Compass", EquipType.Waist, name: "EquipCompass");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/DepthMeter", EquipType.Waist, name: "EquipDepth");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/DPSMeter", EquipType.Front, name: "EquipDPS");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/GPS", EquipType.Shield, name: "EquipGPS");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/FishermansPocketGuide", EquipType.Waist, name: "EquipFishGuide");
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