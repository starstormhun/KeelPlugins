﻿using BepInEx;
using KeelPlugins.Koikatu;
using KKAPI;
using KKAPI.Maker;

[assembly: System.Reflection.AssemblyFileVersion(ClothingStateMenuX.Koikatu.ClothingStateMenu.Version)]

namespace ClothingStateMenuX.Koikatu
{
    [BepInProcess(Constants.MainGameProcessName)]
    [BepInDependency(KoikatuAPI.GUID)]
    [BepInPlugin("keelhauled.clothingstatemenux", "ClothingStateMenuX", Version)]
    public class ClothingStateMenu : BaseUnityPlugin
    {
        public const string Version = "1.0.3." + BuildNumber.Version;

        private void Awake()
        {
            MakerAPI.MakerStartedLoading += (x, y) => UI.CreateUI();
        }
    }
}
