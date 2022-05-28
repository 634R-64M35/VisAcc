using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using VisAcc.Items;

namespace VisAcc {
    public class VisAccGlobalProjectile : GlobalProjectile {
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            VisAccPlayer modPlayer = Main.LocalPlayer.GetModPlayer<VisAccPlayer>();
            if (modPlayer.lavaProof &&
                (projectile.type == ProjectileID.BobberBloody
                || projectile.type == ProjectileID.BobberFiberglass
                || projectile.type == ProjectileID.BobberFisherOfSouls
                || projectile.type == ProjectileID.BobberFleshcatcher
                || projectile.type == ProjectileID.BobberGolden
                || projectile.type == ProjectileID.BobberHotline
                || projectile.type == ProjectileID.BobberMechanics
                || projectile.type == ProjectileID.BobberReinforced
                || projectile.type == ProjectileID.BobberScarab
                || projectile.type == ProjectileID.BobbersittingDuck
                || projectile.type == ProjectileID.BobberWooden)) {
                modPlayer.lavaProof = false;
            }
        }
        public override bool PreDraw(Projectile projectile, ref Color drawColor) {
            VisAccPlayer modPlayer = Main.LocalPlayer.GetModPlayer<VisAccPlayer>();
            if (modPlayer.lavaProof &&
                (projectile.type == ProjectileID.BobberBloody
                || projectile.type == ProjectileID.BobberFiberglass
                || projectile.type == ProjectileID.BobberFisherOfSouls
                || projectile.type == ProjectileID.BobberFleshcatcher
                || projectile.type == ProjectileID.BobberGolden
                || projectile.type == ProjectileID.BobberHotline
                || projectile.type == ProjectileID.BobberMechanics
                || projectile.type == ProjectileID.BobberReinforced
                || projectile.type == ProjectileID.BobberScarab
                || projectile.type == ProjectileID.BobbersittingDuck
                || projectile.type == ProjectileID.BobberWooden)) {
                Main.instance.LoadProjectile(projectile.type);
                Texture2D hook = ModContent.Request<Texture2D>("VisAcc/Textures/LavaProofFishingHook").Value;
                Vector2 drawOrigin = new(hook.Width / 2, hook.Height / 2);
                Main.EntitySpriteDraw(hook, projectile.position - Main.screenPosition + new Vector2(15, 7), hook.Bounds, drawColor, projectile.rotation, 
                    drawOrigin, projectile.scale, SpriteEffects.None, 0);
                return false;
            }
            return true;
        }
    }
}