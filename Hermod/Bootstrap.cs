using System.Threading.Tasks;
using BepInEx;

namespace Hermod
{
    [BepInPlugin("com.cyr1en.hermod", "Hermod", "0.1.0")]
    class Bootstrap : BaseUnityPlugin
    {
        public static Hermod Instance { get; set; }

        private void Awake()
        {
            MainAsync().GetAwaiter().GetResult();
            Instance = new Hermod(this);
        }

        private void OnDestroy()
        {
            Hermod.HermodPatcher.UnpatchAll();
        }

        async Task MainAsync()
        {

        }
    }


}
