using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BepInEx.Configuration;
using DSharpPlus;

namespace Hermod
{
    public class HermodBot
    {
        public DiscordClient Client { get; }

        public HermodBot(Hermod hermod)
        {
            Client = new DiscordClient(new DiscordConfiguration()
            {
                Token = hermod.HConfig.Token.Value,
                TokenType = TokenType.Bot
            });
        }
    }
}