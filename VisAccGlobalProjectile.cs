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
		public override bool InstancePerEntity
			=> true;

		public static readonly Color[] PossibleLineColors = new Color[] {
			new Color(255, 215, 0), // A gold color
			new Color(0, 191, 255) // A blue color
		};

		public override void OnSpawn(Projectile projectile, IEntitySource source) {
			VisAccPlayer modPlayer = Main.LocalPlayer.GetModPlayer<VisAccPlayer>();
			if (modPlayer.lavaProof && projectile.bobber) {
				modPlayer.lavaProof = false;
			}
			modPlayer.highTest = false;
		}

		public override bool PreDraw(Projectile projectile, ref Color drawColor)
		{
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

		public override bool PreDrawExtras(Projectile projectile) {
			VisAccPlayer modPlayer = Main.LocalPlayer.GetModPlayer<VisAccPlayer>();
			if (modPlayer.highTest == true)
			{
				const int XPositionAdditive = 45;
				const float YPositionAdditive = 35f;


				Player player = Main.player[projectile.owner];

				if (!projectile.bobber || player.inventory[player.selectedItem].holdStyle <= 0)
					return false;

				Vector2 lineOrigin = player.MountedCenter;
				lineOrigin.Y += player.gfxOffY;
				int type = player.inventory[player.selectedItem].type;

				// This variable is used to account for Gravitation Potions
				float gravity = player.gravDir;

				lineOrigin.X += XPositionAdditive * player.direction;

				if (player.direction < 0)
					lineOrigin.X -= 13f;
			
				lineOrigin.Y -= YPositionAdditive * gravity;

				if (gravity == -1f)
					lineOrigin.Y -= 12f;

				// RotatedRelativePoint adjusts lineOrigin to account for player rotation.
				lineOrigin = player.RotatedRelativePoint(lineOrigin + new Vector2(8f), true) - new Vector2(8f);
				Vector2 playerToProjectile = projectile.Center - lineOrigin;
				bool canDraw = true;

				if (playerToProjectile.X == 0f && playerToProjectile.Y == 0f)
					return false;

				float playerToProjectileMagnitude = playerToProjectile.Length();
				playerToProjectileMagnitude = 12f / playerToProjectileMagnitude;
				playerToProjectile *= playerToProjectileMagnitude;
				lineOrigin -= playerToProjectile;
				playerToProjectile = projectile.Center - lineOrigin;

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
			}
			return true;
		}
	}
}