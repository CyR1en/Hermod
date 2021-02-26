using BepInEx;
using BepInEx.Logging;

namespace Hermod
{
    public class Hermod
    {
        public HermodConfiguration HConfig { get; }

        public static ManualLogSource HLogger { get; set; }
        public static HermodPatcher HermodPatcher { get; set; }

        public Hermod(BaseUnityPlugin bootstrap)
        {
            var patcher = new HermodPatcher(this);
            patcher.PatchAll();
            HConfig = new HermodConfiguration(bootstrap);
            HLogger = new ManualLogSource("Hermod");
            Logger.Sources.Add(HLogger);
        }
    }

}
