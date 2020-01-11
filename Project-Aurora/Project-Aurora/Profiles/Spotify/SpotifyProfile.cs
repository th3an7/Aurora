using Aurora.Devices;
using Aurora.EffectsEngine.Animations;
using Aurora.Profiles.Minecraft.Layers;
using Aurora.Settings;
using Aurora.Settings.Layers;
using Aurora.Settings.Overrides;
using Aurora.Settings.Overrides.Logic;
using Aurora.Settings.Overrides.Logic.Builder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.Spotify
{
    public class SpotifyProfile : ApplicationProfile
    {
        public SpotifyProfile() : base() { }

        public override void Reset()
        {
            base.Reset();

            OverlayLayers = new System.Collections.ObjectModel.ObservableCollection<Layer>()
            {
                new Layer("TEST", new SolidColorLayerHandler()
                {
                    Properties = new LayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Red,
                        _Sequence = new KeySequence(new DeviceKeys[]{ DeviceKeys.F1})
                    }
                }, new OverrideLogicBuilder().SetDynamicBoolean("_Enabled", new BooleanGSIBoolean("Player/Playing")))
            };
        }
    }
}