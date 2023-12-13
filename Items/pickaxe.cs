using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstTry.Items
{
	public class pickaxe : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.FirstTry.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 3;
			Item.useAnimation = 10;
			Item.pick = 1000;
			Item.axe = 1000;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 100000;
			Item.rare = 3;
			Item.UseSound = SoundID.QueenSlime;
			Item.autoReuse = true;
			Item.useTurn = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.Register();
		}
	}
}