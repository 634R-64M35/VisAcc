using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc {
	public class VisAccPlayer : ModPlayer {
		public bool highTest;
		public bool lavaProof;
		public bool catEars;

		public override void ResetEffects() {
			highTest = false;
			lavaProof = false;
			catEars = false;
        }

		public override void UpdateEquips() {
            if (Player.armor[10].type == ModContent.ItemType<CatEars>())
                catEars = true;
        }

		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath) {
			if (Player.name == "Maple" || Player.name == "maple")
				return new[] { new Item(ModContent.ItemType<MaplesStylishBowtie>()) };

			if (Player.name == "Reika" || Player.name == "Ada" || Player.name == "reika" || Player.name == "ada")
				return new[] { new Item(ModContent.ItemType<CatEars>()) };

			return Enumerable.Empty<Item>();
		}
	}
}