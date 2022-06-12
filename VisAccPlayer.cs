using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc {
	public class VisAccPlayer : ModPlayer {
		public bool highTest;
		public bool lavaProof;
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath) {
			return Player.name != "Mathew" ?
				Player.name != "Maple" ?
				Player.name != "Draedon" ?
				Player.name != "Draedon Gaming" ?
				Player.name != "Ada" ?
				Player.name != "Phoebe" ?
				Enumerable.Empty<Item>()
				: new[] { new Item(ModContent.ItemType<CatEars>()) }
				: new[] { new Item(ModContent.ItemType<CatEars>()) }
				: new[] { new Item(ModContent.ItemType<CatEars>()) }
				: new[] { new Item(ModContent.ItemType<CatEars>()) }
				: new[] { new Item(ModContent.ItemType<MathewsStylishBowtie>()) }
				: new[] { new Item(ModContent.ItemType<MathewsStylishBowtie>()) };
		}
		public override void Initialize() {
			highTest = false;
			lavaProof = false;
		}
	}
}