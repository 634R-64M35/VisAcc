using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace VisAcc {
    public class VisAccGlobalProjectile : GlobalProjectile {
        public override bool InstancePerEntity => true;

        public static readonly Color[] PossibleLineColors = new Color[] {
            new Color(255, 215, 0), // A gold color
			new Color(0, 191, 255) // A blue color
		};

        private int fishingLineColorIndex;

        private Color FishingLineColor => PossibleLineColors[fishingLineColorIndex];

        public override void OnSpawn(Projectile projectile, IEntitySource source) {
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
                modPlayer.highTest = false;
            }
            // Decide color of the pole by getting the index of a random entry from the PossibleLineColors array.
            fishingLineColorIndex = (byte)Main.rand.Next(PossibleLineColors.Length);
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
    /*public class VisAccFishingLine : ModProjectile
    {
        public override void ModifyFishingLine(ref Vector2 lineOriginOffset, ref Color lineColor)
        {
            // Change these two values in order to change the origin of where the line is being drawn.
            // This will make it draw 47 pixels right and 31 pixels up from the player's center, while they are looking right and in normal gravity.
            lineOriginOffset = new Vector2(47, -31);
            // Sets the fishing line's color. Note that this will be overridden by the colored string accessories.
            lineColor = FishingLineColor;
        }
    }*/
}