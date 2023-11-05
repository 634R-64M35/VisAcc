using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;


namespace VisAcc.Items {
    [AutoloadEquip(EquipType.Head)]
    public class CatEars : ModItem {
        public override void SetStaticDefaults() =>
            ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;

        public override void SetDefaults() {
            Item.width = 30;
            Item.height = 24;
            Item.value = Item.sellPrice(0, 1, 6, 69);
            Item.rare = ItemRarityID.Orange;
            Item.vanity = true;
            Item.accessory = true;
        }

        public override void UpdateEquip(Player player) {
            player.GetModPlayer<VisAccPlayer>().catEars = true;
        }

        public override void UpdateVanity(Player player) {
            player.GetModPlayer<VisAccPlayer>().catEars = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            foreach (TooltipLine tooltipLine in tooltips)
                if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
                    tooltipLine.OverrideColor = new Color(235, 4, 80);
        }
    }
}