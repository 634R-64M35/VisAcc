using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ReLogic.Content;
using Terraria.Graphics.Shaders;

namespace VisAcc.Items {
    public class ArmorPolishDye : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Armor Polish Dye");
            Tooltip.SetDefault("Unobtainable, only used to set an ID for the dye to be used when necessary");
            if (!Main.dedServ) {
                GameShaders.Armor.BindShader(Item.type, new ArmorShaderData(new Ref<Effect>(Mod.Assets.Request<Effect>("Effects/ArmorPolishShader", AssetRequestMode.ImmediateLoad).Value), "ArmorPolishShaderPass")).UseColor(0.65f, 0.65f, 0.65f);
            }
        }

        public override void SetDefaults() {
            int  dye = Item.dye;
            Item.CloneDefaults(ItemID.GelDye);
            Item.width = 22;
            Item.height = 26;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Item.dye = dye;
        }
    }
}