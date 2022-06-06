using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;

namespace VisAcc.Items {
    [AutoloadEquip(EquipType.Head)]
    public class CatEars : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("RGB Cat Ears");
            Tooltip.SetDefault(VisAcc.month == 4 ? "Burunyuu!" : "Glows in the dark!\nDev Item");
            ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            foreach (TooltipLine tooltipLine in tooltips)
                if (tooltipLine.Mod == "Terraria" && tooltipLine.Name == "ItemName")
                    tooltipLine.OverrideColor = new Color(235, 4, 80);
        }

        public override void SetDefaults() {
            Item.width = 22;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 0, 16, 69);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
            Item.vanity = true;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI) {
            Texture2D glowMask = ModContent.Request<Texture2D>("VisAcc/Items/CatEars_Head_Glow").Value;
            Rectangle frame = glowMask.Frame(1, 20, 20);
            Main.EntitySpriteDraw (glowMask, Item.position, frame, Color.White, 0f, new Vector2(0, 0), 1, SpriteEffects.None, 0);
        }
    }
}