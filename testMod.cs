using MelonLoader;
using BTD_Mod_Helper;
using testMod;
using Il2CppAssets.Scripts.Data.Behaviors.Simulations;
using Il2CppAssets.Scripts.Unity.Map;
using System.Diagnostics;

[assembly: MelonInfo(typeof(testMod.testMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace testMod;

public class testMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<testMod>("testMod loaded!");
    }

    public override void OnRoundStart()
    {
        base.OnRoundStart();
        Debug.WriteLine("Bruh round started");
    }
}