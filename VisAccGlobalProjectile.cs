using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc {
    public class VisAccGlobalProjectile : GlobalProjectile {
        public override bool PreDraw(Projectile projectile, ref Color drawColor) {
            if (projectile.type == ProjectileID.BobberWooden) {
                Main.instance.LoadProjectile(projectile.type);
                Texture2D hook = ModContent.Request<Texture2D>("VisAcc/Textures/LavaProofFishingHook").Value;
                Vector2 drawOrigin = new Vector2(hook.Width, projectile.height);
                Main.EntitySpriteDraw(hook, projectile.position - Main.screenPosition - new Vector2 (-8, 0), hook.Bounds, drawColor, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0);
                return false;
            }
            return true;
        }
    }
}