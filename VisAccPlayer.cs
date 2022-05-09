using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc
{
	public class VisAccPlayer : ModPlayer
	{
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
		{
			return Player.name != "Mathew" ?
				Player.name != "Maple" ?
				Enumerable.Empty<Item>()
				: new[] { new Item(ModContent.ItemType<MathewsStylishBowtie>()) }
				: new[] { new Item(ModContent.ItemType<MathewsStylishBowtie>()) };
		}
	}
}