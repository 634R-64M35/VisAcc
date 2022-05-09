using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace VisAcc.Items
{
    [AutoloadEquip(EquipType.Face)]
    public class CatEars : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("RGB Cat Ears");
            Tooltip.SetDefault("Glows in the dark!\nDev Item");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
                if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
                    tooltipLine.OverrideColor = new Color(235, 4, 80);
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 22;
            Item.value = Item.sellPrice(0, 0, 16, 69);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
            Item.vanity = true;
        }
	}
}