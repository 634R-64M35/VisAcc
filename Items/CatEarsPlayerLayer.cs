using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace VisAcc.Items {
    public class CatEarsPlayerLayer : PlayerDrawLayer {
        public static int frame;
        public static int frameCounter;
        public static bool CatEars = false;
        public override bool IsHeadLayer => true;
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Head);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo) {
            if (drawInfo.drawPlayer.GetModPlayer<VisAccPlayer>().catEars)
                CatEars = true;
            return CatEars;
        }

        protected override void Draw(ref PlayerDrawSet drawInfo) {
            if (drawInfo.shadow != 0f)
                return;

            Mortis(ref drawInfo, "CatEars_Anim_Front");
        }

        public static void Mortis(ref PlayerDrawSet drawInfo, string texName) {
            Player drawPlayer = drawInfo.drawPlayer;
            int secondyoffset;
            var bodFrame = drawPlayer.bodyFrame;
            int dyeShader = drawPlayer.dye?[1].dye ?? 0;
            for (int n = 0; n < 18 + drawInfo.drawPlayer.extraAccessorySlots; n++) {
                Item item = drawInfo.drawPlayer.armor[n];
                if (item.type == ModContent.ItemType<CatEars>()) {
                    if (n > 9)
                        dyeShader = drawPlayer.dye?[n - 10].dye ?? 0;
                    else
                        dyeShader = drawPlayer.dye?[n].dye ?? 0;
                }
            }
             
            if (bodFrame.Y == bodFrame.Height * 7 || bodFrame.Y == bodFrame.Height * 8 || bodFrame.Y == bodFrame.Height * 9
                || bodFrame.Y == bodFrame.Height * 14 || bodFrame.Y == bodFrame.Height * 15 || bodFrame.Y == bodFrame.Height * 16)
                secondyoffset = 2;
            else
                secondyoffset = 0;

            frameCounter++;
            if (frameCounter > 4) {
                frameCounter = 0;
                frame++;
                if (frame > 8)
                    frame = 0;
            }

            Vector2 headPosition = new Vector2(
                (int)(drawInfo.Position.X - (drawInfo.drawPlayer.bodyFrame.Width / 2) + (drawInfo.drawPlayer.width / 2)),
                   (int)(drawInfo.Position.Y + drawInfo.drawPlayer.height) - (float)drawInfo.drawPlayer.bodyFrame.Height - secondyoffset)
               + drawInfo.drawPlayer.headPosition + drawInfo.headVect;

            headPosition -= Main.screenPosition;

            Texture2D texture = ModContent.Request<Texture2D>("VisAcc/Items/" + texName).Value;
            Rectangle yFrame = texture.Frame(1, 9, 0, frame);
            DrawData dat = new DrawData(texture, new Vector2(headPosition.X - (1 * drawPlayer.direction), headPosition.Y - 5), yFrame, drawInfo.colorArmorHead,
                0f, new Vector2(texture.Width / 2f, texture.Height / 2f / 9f), 1f, drawPlayer.direction != -1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally, 0);
            dat.shader = dyeShader;
            drawInfo.DrawDataCache.Add(dat);
        }

    }
    public class CatEarsPlayerLayerBack : PlayerDrawLayer {
        public override bool IsHeadLayer => true;
        public override Position GetDefaultPosition() => new BeforeParent(PlayerDrawLayers.Head);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo) { 
            return CatEarsPlayerLayer.CatEars; 
        }

        protected override void Draw(ref PlayerDrawSet drawInfo) {
            if (drawInfo.shadow != 0f)
                return;

            CatEarsPlayerLayer.Mortis(ref drawInfo, "CatEars_Anim_Back");
        }

    }
}