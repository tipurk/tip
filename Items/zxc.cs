using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FirstTry.Items
{
	public class zxc : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.FirstTry.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 70;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 1000000000;
			Item.rare = 3;
			Item.UseSound = SoundID.QueenSlime;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.CursedArrow;
			Item.shootSpeed = 30;
			Item.shootsEveryUse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.Register();
		}
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            base.OnHitNPC(player, target, hit, damageDone);
			target.position = new Vector2(0,0);
        }
    }
}