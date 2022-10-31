using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc {
	public class VisAccPlayer : ModPlayer {
		public bool highTest;
		public bool lavaProof;

		public override void ResetEffects() {
			highTest = false;
			lavaProof = false;
		}

		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath) {
			if (Player.name == "Mathew" || Player.name == "Maple") {
				return new[] { new Item(ModContent.ItemType<MathewsStylishBowtie>()) };
			}

			if (Player.name == "Draedon" || Player.name == "Draedon Gaming" || Player.name == "Phoebe" || Player.name == "Ada") {
				return new[] { new Item(ModContent.ItemType<CatEars>()) };
			}

			return Enumerable.Empty<Item>();
		}
	}
}