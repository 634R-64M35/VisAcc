using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc
{
    public class VisAccGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            foreach (Item i in player.armor)
            {
                if (i.type == ItemID.AnkletoftheWind)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAnklet", EquipType.Shoes);
                }
                if (i.type == ItemID.LavaCharm)
                {
                    player.waist = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLavaCharm", EquipType.Waist);
                }
                if (i.type == ItemID.LuckyHorseshoe)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipLuckyHonse", EquipType.Shoes);
                }
                if (i.type == ItemID.MoltenCharm)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipMoltCharm", EquipType.Waist);
                }
                if (i.type == ItemID.NeptunesShell)
                {
                    player.shield = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipNepShell", EquipType.Waist);
                }
                if (i.type == ItemID.ObsidianHorseshoe)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipObsHonse", EquipType.Shoes);
                }
                if (i.type == ItemID.Aglet)
                {
                    player.shoe = (sbyte)EquipLoader.GetEquipSlot(Mod, "EquipAglet", EquipType.Shoes);
                }
            }
        }
    }
}