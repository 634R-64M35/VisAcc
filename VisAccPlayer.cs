using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc {
	public class VisAccPlayer : ModPlayer {
		public bool highTest;
		public bool lavaProof;
		public bool armorPolish;

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

        public override void ModifyDrawInfo(ref PlayerDrawSet drawInfo) {
			if (armorPolish == true) {
				Player.cHead = VisAccGlobalItem.shaderID;
				Player.cBody = VisAccGlobalItem.shaderID;
				Player.cLegs = VisAccGlobalItem.shaderID;
			}
			armorPolish = false;
		}

        public override void Initialize() {
			highTest = false;
			lavaProof = false;
			armorPolish = false;
		}
	}
}