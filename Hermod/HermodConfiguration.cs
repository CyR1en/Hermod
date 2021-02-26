using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;

namespace Hermod
{
    public class HermodConfiguration
    {
        public ConfigEntry<string> Token { get; }

        public HermodConfiguration(BaseUnityPlugin bootstrap)
        {
            Token = bootstrap.Config.Bind("Bot Configuration", "Token", "sample.token", "Token for the bot");
        }
    }
}
