using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;
using FirstTry;
using FirstTry.Projectiles;

namespace FirstTry.Items
{
    public class yo : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.FirstTry.hjson file.

        public override void SetDefaults()
        {
            ItemID.Sets.Yoyo[Item.type] = true;
            Item.damage = 300;
            Item.DamageType = DamageClass.Generic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 32;
            Item.useAnimation = 32;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 4;
            Item.value = 1000000000;
            Item.rare = 5;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.noUseGraphic = true;
            Item.channel = true;
            Item.shoot = ModContent.ProjectileType<yoprojectile>();
            Item.shootSpeed = 6f;
            Item.noMelee = true; 

        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            var lineToChange = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.Mod == "Terraria");
            if (lineToChange != null)
            {
                string[] split = lineToChange.Text.Split(' ');
                lineToChange.Text = split.First() + " yo " + split.Last();
            }
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.Register();
        }
    }
}