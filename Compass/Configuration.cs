﻿using System.Collections.Generic;
using System.Numerics;
using Dalamud.Configuration;
using Newtonsoft.Json;
using SimpleTweaksPlugin.Debugging;

namespace Compass
{
    public class Configuration : IPluginConfiguration
    {
#if DEBUG
        public DebugConfig Debugging = new();
#endif
        [JsonIgnore] public Vector2 AddonCompassOffset = new(0,0);
        [JsonIgnore] public float AddonCompassScale = 1f;
        [JsonIgnore] public int AddonCompassWidth = 550;
        // NOTE (Chiv) ImGuiCompass Offset/Position are saved as the window coords/size.
        [JsonIgnore] public int AddonCompassBackgroundPartId = 1;
        [JsonIgnore] public bool AddonCompassDisableBackground;
        [JsonIgnore] public bool AddonCompassEnable;
        
        public float ImGuiCompassScale = 1f;
        public bool ImGuiCompassEnableBackground = true;
        public bool ImGuiCompassDrawBorder = true;
        public bool ImGuiCompassFillBackground = false;
        public Vector4 ImGuiBackgroundColour = new(0.2f,0.2f,0.2f,0.2f);
        public Vector4 ImGuiBackgroundBorderColour = new(0.2f,0.2f,0.2f,1f);
        public float ImGuiCompassBackgroundRounding = 10f;

        public bool ImGuiCompassEnableCenterMarker = true;
        public bool ImGuiCompassFlipCentreMarker;
        public int ImGuiCompassCentreMarkerOffset = 27;
        public bool ImGuiCompassEnable = true;

        public bool HideOnAreaMap;
        public bool HideOnDialogueBox;
        public bool HideOnBattleTalk;
        public bool HideOnInventories;
        public bool HideOnSkillTooltip;
        public bool HideOnItemTooltip;
        public bool HideInCombat;
        public bool HideInPvPMaps;
        public bool HideInInstances;

        public int Version { get; set; } = 0;
    }

}