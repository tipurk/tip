using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace FirstTry
{
	public class GlobalPlayer : ModPlayer
	{
		public bool socks = false;

        public override void PostUpdate()
        {
            if (Player.velocity.X != 0 && socks)
            {
                int dust = Dust.NewDust(Player.position, Player.width, Player.height, 17, 0f, 0f, 0, Colors.RarityTrash, 1f);
                Main.dust[dust].noGravity = true;
                Main.dust[dust].velocity *= 0;
            }
        }

        public override void ResetEffects()
        {
            socks = false;
        }
    }
}