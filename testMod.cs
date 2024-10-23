using MelonLoader;
using BTD_Mod_Helper;
using testMod;

[assembly: MelonInfo(typeof(testMod.testMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace testMod;

public class testMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<testMod>("testMod loaded!");
    }
}