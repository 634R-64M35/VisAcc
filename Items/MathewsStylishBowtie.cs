using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace VisAcc.Items
{
    [AutoloadEquip(EquipType.Neck)]
    public class MathewsStylishBowtie : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mathew's Stylish Bowtie");
            Tooltip.SetDefault("Dev Item");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
                if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
                    tooltipLine.OverrideColor = new Color(107, 240, 255);
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 22;
            Item.value = Item.sellPrice(0, 0, 91, 79);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
            Item.vanity = true;
        }
	}
}