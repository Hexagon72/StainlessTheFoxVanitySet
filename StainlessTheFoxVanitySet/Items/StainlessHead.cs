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
	[AutoloadEquip(EquipType.Head)]
    public class StainlessHead : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = -12;
            item.vanity = true;
        }
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stainless' Head");
			Tooltip.SetDefault("uwu");
		}
		public override bool DrawHead()
		{
			return false;
		}
    }
}