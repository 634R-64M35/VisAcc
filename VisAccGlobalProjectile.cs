using CsvHelper.TypeConversion;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace VisAcc {
	public class VisAccGlobalProjectile : GlobalProjectile {
        // Checks if a bobber was created and if any fishing item is equipped, resets both fishing vars
        public override void OnSpawn(Projectile projectile, IEntitySource source) {
            VisAccPlayer modPlayer = Main.LocalPlayer.GetModPlayer<VisAccPlayer>();
            modPlayer.lavaProof = false;
			modPlayer.highTest = false;
		}

		// Draws the bobber/hook
		public override bool PreDraw(Projectile projectile, ref Color drawColor) {
            VisAccPlayer modPlayer = Main.LocalPlayer.GetModPlayer<VisAccPlayer>();
            if (modPlayer.lavaProof && projectile.bobber) {
				Main.instance.LoadProjectile(projectile.type);
				Texture2D hook = ModContent.Request<Texture2D>("VisAcc/Textures/LavaProofFishingHook").Value;
				Vector2 drawOrigin = new(hook.Width / 2, hook.Height / 2);
				Main.EntitySpriteDraw(hook, projectile.position - Main.screenPosition + new Vector2(15, 7), hook.Bounds, drawColor, projectile.rotation,
					drawOrigin, projectile.scale, SpriteEffects.None, 0);
				return false;
			}
			return true;
		}

		// Old code for overriding high test fishing line, removed for the time being

		/*public override bool PreDrawExtras(Projectile projectile) {
            VisAccPlayer modPlayer = Main.LocalPlayer.GetModPlayer<VisAccPlayer>();
            Player player = Main.player[projectile.owner];

            if (modPlayer.highTest && projectile.bobber) {
                #region Vars
                // Sets line origin
                int xPositionAdditive = 45;
                float yPositionAdditive = 35f;
				float gravity = player.gravDir;
                Vector2 lineOrigin = player.MountedCenter;
                lineOrigin.Y += player.gfxOffY;

				// Adjusts based on player gravity and direction
                lineOrigin.X += xPositionAdditive * player.direction;
                if (player.direction < 0)
                    lineOrigin.X -= 13f;
                lineOrigin.Y -= yPositionAdditive * gravity;
                if (gravity == -1f)
					lineOrigin.Y -= 12f;

				// Adjusts based on player rotation
				lineOrigin = player.RotatedRelativePoint(lineOrigin + new Vector2(8f), true) - new Vector2(8f);
				Vector2 playerToProjectile = projectile.Center - lineOrigin;
				bool canDraw = true;

                // Guh
                float playerToProjectileMagnitude = playerToProjectile.Length();
                playerToProjectileMagnitude = 12f / playerToProjectileMagnitude;
                playerToProjectile *= playerToProjectileMagnitude;
                lineOrigin -= playerToProjectile;
                playerToProjectile = projectile.Center - lineOrigin;

                if ((playerToProjectile.X == 0f && playerToProjectile.Y == 0f) || player.inventory[player.selectedItem].holdStyle <= 0)
					return false;
                #endregion

                #region Meat and Potatoes
                // This math draws the line, while allowing the line to sag.
                while (canDraw) {
					float height = 12f;
					float positionMagnitude = playerToProjectile.Length();

					if (float.IsNaN(positionMagnitude) || float.IsNaN(positionMagnitude))
						break;

					if (positionMagnitude < 20f) {
						height = positionMagnitude - 8f;
						canDraw = false;
					}

					playerToProjectile *= 12f / positionMagnitude;
					lineOrigin += playerToProjectile;
					playerToProjectile.X = projectile.position.X + projectile.width * 0.5f - lineOrigin.X;
					playerToProjectile.Y = projectile.position.Y + projectile.height * 0.1f - lineOrigin.Y;

					if (positionMagnitude > 12f) {
						float positionInverseMultiplier = 0.3f;
						float absVelocitySum = Math.Abs(projectile.velocity.X) + Math.Abs(projectile.velocity.Y);

						absVelocitySum = Math.Min(absVelocitySum, 16f);
						absVelocitySum = 1f - absVelocitySum / 16f;
						positionInverseMultiplier *= absVelocitySum;
						absVelocitySum = positionMagnitude / 80f;
						absVelocitySum = Math.Min(absVelocitySum, 1f);

						positionInverseMultiplier *= absVelocitySum;
						positionInverseMultiplier = Math.Max(positionInverseMultiplier, 0f);

						absVelocitySum = 1f - projectile.localAI[0] / 100f;
						positionInverseMultiplier *= absVelocitySum;

						if (playerToProjectile.Y > 0f) {
							playerToProjectile.Y *= 1f + positionInverseMultiplier;
							playerToProjectile.X *= 1f - positionInverseMultiplier;
						} else {
							absVelocitySum = Math.Abs(projectile.velocity.X) / 3f;
							absVelocitySum = Math.Min(absVelocitySum, 1f);
							absVelocitySum -= 0.5f;
							positionInverseMultiplier *= absVelocitySum;

							if (positionInverseMultiplier > 0f) {
								positionInverseMultiplier *= 2f;
							}

							playerToProjectile.Y *= 1f + positionInverseMultiplier;
							playerToProjectile.X *= 1f - positionInverseMultiplier;
						}

						var texture = TextureAssets.FishingLine.Value;
						var linePos = new Vector2(lineOrigin.X - Main.screenPosition.X + texture.Width * 0.5f + 1, lineOrigin.Y - Main.screenPosition.Y + texture.Height * 0.5f + 1);
						var sourceRectangle = new Rectangle(0, 0, texture.Width, (int)height);
						float rotation = playerToProjectile.ToRotation() - MathHelper.PiOver2;
						var origin = new Vector2(texture.Width * 0.5f, 0f);

						Main.EntitySpriteDraw(texture, linePos + new Vector2(2, 2), sourceRectangle, Color.DarkGray, rotation, origin, 1f, SpriteEffects.None, 0);
						Main.EntitySpriteDraw(texture, linePos, sourceRectangle, Color.DimGray, rotation, origin, 1f, SpriteEffects.None, 0);
						Main.EntitySpriteDraw(texture, linePos - new Vector2(2, 2), sourceRectangle, Color.DarkGray, rotation, origin, 1f, SpriteEffects.None, 0);
					}
				}
				return false;
                #endregion
            }
            return true;
		}*/
	}
}