using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace VisAcc
{
	public class VisAcc : Mod
	{
        public static VisAcc instance;

        public enum MessageType
        {
            SyncVisAccPlayer
        }

        public static Effect TrailEffect;

        public static string currentDate;
        public static int day;
        public static int month;

        public override void Load()
        {
            instance = this;
            /*if (Main.netMode != NetmodeID.Server)
            {
                TrailEffect = GetEffect("Effects/TrailShader");

                Ref<Effect> invertRef = new Ref<Effect>(GetEffect("Effects/Grayscale"));
                Ref<Effect> shockwaveRef = new Ref<Effect>(GetEffect("Effects/Shockwave"));

                Filters.Scene["VadesContentMod:Grayscale"] = new Filter(new ScreenShaderData(invertRef, "Main"), EffectPriority.VeryHigh);
                Filters.Scene["VadesContentMod:Shockwave"] = new Filter(new ScreenShaderData(shockwaveRef, "Shockwave"), EffectPriority.VeryHigh);
            }*/


            DateTime dateTime = DateTime.Now;
            currentDate = dateTime.ToString("dd/MM/yyyy");
            day = dateTime.Day;
            month = dateTime.Month;
        }

        public override void Unload()
        {
            instance = null;
        }

        public override void PostSetupContent()
        {
            //if (ModContent.GetInstance<VisAccConfig>().DiscordRichPresence)
            //{
            //}
        }

        /*public override void HandlePacket(BinaryReader reader, int whoAmI)
        {
            MessageType messageType = (MessageType)reader.ReadByte();
            byte playerNumber;
            VisAccPlayer VisAccPlayer;
            switch (messageType)
            {
                case MessageType.SyncVisAccPlayer:
                    playerNumber = reader.ReadByte();
                    VisAccPlayer = Main.player[playerNumber].GetModPlayer<VisAccPlayer>();
                    break;

                default:
                    Logger.WarnFormat("Visual Accessories: Unknown Message Type: {0}", messageType);
                    break;
            }
        }*/
    }
}