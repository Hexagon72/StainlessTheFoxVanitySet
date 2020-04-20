using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent;
using Terraria.IO;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria.ModLoader;
using Terraria.Localization;

namespace StainlessTheFoxVanitySet.Items
{
	[AutoloadEquip(EquipType.Legs)]
    public class StainlessLegs : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 14;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = -12;
            item.vanity = true;
        }
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stainless' Legs");
			Tooltip.SetDefault("x3");
		}
    }
}