using Aurora.EffectsEngine;
using Aurora.EffectsEngine.Animations;
using Aurora.Settings;
using Aurora.Settings.Layers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DK = Aurora.Devices.DeviceKeys;

namespace Aurora.Profiles.TeamSpeak
{
    public class TeamSpeakProfile : ApplicationProfile
    {
        public TeamSpeakProfile() : base() { }

        public override void Reset()
        {
            base.Reset();

            Layers = new System.Collections.ObjectModel.ObservableCollection<Layer>
            {
                new Layer("Input Muted", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties
                    {
                        _VariablePath = "TeamSpeakNode/onClientSelfVariableUpdateEvent/flag",
                        _PrimaryColor = Color.FromArgb(255,255,0,0),
                        _SecondaryColor = Color.FromArgb(0,0,0,0),
                        _Sequence = new KeySequence(new[]{DK.PAGE_UP})
                    }
                }),

                new Layer("Output Muted", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties
                    {
                        _VariablePath = "TeamSpeakNode/onClientSelfVariableUpdateEvent/flag",
                        _PrimaryColor = Color.FromArgb(255,255,0,0),
                        _SecondaryColor = Color.FromArgb(0,0,0,0),
                        _Sequence = new KeySequence(new[]{DK.PAGE_DOWN})
                    }
                }),

                new Layer("Talking", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties
                    {
                        _VariablePath = "TeamSpeakNode/onTalkStatusChangeEvent/status",
                        _PrimaryColor = Color.FromArgb(255,0,255,0),
                        _SecondaryColor = Color.FromArgb(0,0,0,0),
                        _Sequence = new KeySequence(new[]{DK.NUM_ONE, DK.NUM_TWO, DK.NUM_THREE, DK.NUM_FOUR, DK.NUM_FIVE, DK.NUM_SIX, DK.NUM_SEVEN, DK.NUM_EIGHT, DK.NUM_NINE})
                    }
                }),

                new Layer("Moved", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties
                    {
                        _VariablePath = "TeamSpeakNode/onClientMoveEvent/newChannelID",
                        _PrimaryColor = Color.FromArgb(255,255,255,255),
                        _SecondaryColor = Color.FromArgb(0,0,0,0),
                        _Sequence = new KeySequence(new[]{DK.ARROW_DOWN, DK.ARROW_LEFT, DK.ARROW_RIGHT, DK.ARROW_UP})
                    }
                }),

                new Layer("Connecting", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties()
                    {
                        _VariablePath = "TeamSpeakNode/onConnectStatusChangeEvent/serverConnectionHandlerID",
                        _MaxVariablePath = "4",
                        _PrimaryColor = Color.FromArgb(255,0,0),
                        _SecondaryColor = Color.Transparent,
                        _Sequence = new KeySequence(new[]{DK.ONE, DK.TWO, DK.THREE, DK.FOUR, DK.FIVE, DK.SIX, DK.SEVEN, DK.EIGHT, DK.NINE, DK.ZERO}),
                        _BlinkThreshold = 0
                    }
                }),

                new Layer("Kicked", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties
                    {
                        _VariablePath = "TeamSpeakNode/onClientKickFromChannelEvent/oldChannelID",
                        _MaxVariablePath = "3",
                        _PrimaryColor = Color.FromArgb(255,0,0),
                        _SecondaryColor = Color.FromArgb(0,0,255),
                        _Sequence = new KeySequence(new[]{DK.ARROW_DOWN, DK.ARROW_LEFT, DK.ARROW_RIGHT, DK.ARROW_UP})
                    }
                }),

                new Layer("Message", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties
                    {
                        _VariablePath = "TeamSpeakNode/onTextMessageEvent/ffIgnored",
                        _MaxVariablePath = "1",
                        _PrimaryColor = Color.FromArgb(255,0,0),
                        _SecondaryColor = Color.FromArgb(0,0,255),
                        _Sequence = new KeySequence(new[]{DK.ENTER})
                    }
                }),
            };
        }
    }
}
