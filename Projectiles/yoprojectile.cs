using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;
using FirstTry;

namespace FirstTry.Projectiles
{
    public class yoprojectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.YoyosLifeTimeMultiplier[Projectile.type] = 8;
            ProjectileID.Sets.YoyosMaximumRange[Projectile.type] = 260;
            ProjectileID.Sets.YoyosTopSpeed[Projectile.type] = 30;
        }

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.aiStyle = 99;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = -1;
        }
    }
}