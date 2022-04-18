using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;
using System.IO;
using System;
using Microsoft.Xna.Framework;

namespace VisAcc
{
    public class VisAccGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity => true;
        public override GlobalItem Clone(Item item, Item itemClone)
        {
            return base.Clone(item, itemClone);
        }
        public bool Anklet;
        public Terraria.Item AnkletID;
        public override void UpdateEquip(Item item, Player player)
        {
            foreach (Item i in player.miscEquips)
            {
                /*if (i.ItemID == 212)
                {
                    Anklet = true;
                    AnkletID = i;
                }*/
            }
            base.UpdateEquip(item, player);
        }
        public override void Load()
        {
            Mod CalVal = ModLoader.GetMod("CalValEX");
            if (ModLoader.TryGetMod("CalValEX", out var CalValEX))
            {
                if (CalValEX.TryFind<ModItem>("ExodiumMoon", out var ExodiumMoon))
                {
                    Mod.AddEquipTexture(ExodiumMoon, EquipType.Shoes, "VisAcc/Textures/AnkletOfTheWind");
                }
            }
            if (Anklet == true)
            {
                //Mod.AddEquipTexture(AnkletID, EquipType.Legs, "Textures/AnkletOfTheWind");
            }
            base.Load();
        }
    }
}