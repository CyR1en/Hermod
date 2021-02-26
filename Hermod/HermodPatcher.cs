using System;
using System.Collections.Generic;
using System.Linq;
using BepInEx;
using HarmonyLib;

namespace Hermod
{
    public class HermodPatcher
    {
        private readonly Harmony _instance;

        public HermodPatcher(Hermod hermod)
        {
            _instance = new Harmony(hermod.GetType()
                .GetCustomAttributes(typeof(BepInPlugin), false)
                .Cast<BepInPlugin>()
                .First()
                .GUID);
        }

        public void PatchAll()
        {
            _instance.PatchAll(typeof(RPCPatcher));
        }

        public void UnpatchAll()
        {
            _instance.UnpatchSelf();
        }
    }

    class RPCPatcher
    {
        [HarmonyPatch(typeof(ZRoutedRpc), "InvokeRoutedRPC")]
        [HarmonyPostfix]
        void InvokeRoutedRPCPatch(ZRoutedRpc __instance, string methodName, params object[] parameters)
        {
            Hermod.HLogger.LogInfo("Patched InvokeRoutedRPC");
            Hermod.HLogger.LogInfo($"Instance null: {__instance}");
        }
    }
}