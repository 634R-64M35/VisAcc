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
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/LavaCharm", EquipType.Waist, name: "EquipLavaCharm");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/LuckyHorseshoe", EquipType.Shoes, name: "EquipLuckyHonse");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/MoltenCharm", EquipType.Shield, name: "EquipMoltCharm");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/NeptunesShell", EquipType.Shield, name: "EquipNepShell");
                EquipLoader.AddEquipTexture(this, "VisAcc/Textures/ObsidianHorseshoe", EquipType.Shoes, name: "EquipObsHonse");
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