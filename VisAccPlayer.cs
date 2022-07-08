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
		public bool royGel;
		public bool brain;
		public bool volGel;
		public bool spore;
		public bool gGlobe;

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
			if (armorPolish) {
				Player.cHead = VisAccGlobalItem.shaderID;
				Player.cBody = VisAccGlobalItem.shaderID;
				Player.cLegs = VisAccGlobalItem.shaderID;
			}
			if (royGel || volGel) {
				drawInfo.drawPlayer.head = 0;
				drawInfo.fullHair = false;
				drawInfo.hatHair = false;
				drawInfo.hideHair = true;
			}
			if (brain || gGlobe) {
				drawInfo.colorHair = Microsoft.Xna.Framework.Color.Transparent;
				drawInfo.fullHair = false;
				drawInfo.hatHair = false;
				drawInfo.hideHair = true;
			}
			if (spore) {
				drawInfo.drawPlayer.head = 0;
				drawInfo.fullHair = false;
				drawInfo.hatHair = true;
				drawInfo.hideHair = true;
			}
			armorPolish = false;
		}

        public override void HideDrawLayers(PlayerDrawSet drawInfo) {
			if (royGel || volGel) {
				PlayerDrawLayers.HairBack.Hide();
				PlayerDrawLayers.Head.Hide();
			} else if (brain || gGlobe) {
				PlayerDrawLayers.HairBack.Hide();
			} else if (spore) {
				PlayerDrawLayers.HairBack.Hide();
			} else {
				PlayerDrawLayers.HairBack.Load();
				PlayerDrawLayers.Head.Load();
			}
		}


        public override void Initialize() {
			highTest = false;
			lavaProof = false;
			armorPolish = false;
			royGel = false;
			brain = false;
			volGel = false;
			spore = false;
			gGlobe = false;
		}
	}
}