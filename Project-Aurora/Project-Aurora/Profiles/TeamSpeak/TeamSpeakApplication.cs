using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.TeamSpeak {
    public class TeamSpeak : Application {

        public TeamSpeak() : base(new LightEventConfig
        {
        Name = "TeamSpeak 3",
        ID = "teamspeak",
        ProcessNames = new[] { "ts3client_win64.exe", "ts3client_win32.exe"},
        IconURI = "Resources/desktop_icon.png",
        ProfileType = typeof(TeamSpeakProfile),
        OverviewControlType = typeof(Control_TeamSpeak),
        GameStateType = typeof(GSI.GameState_TeamSpeak),
        Event = new GameEvent_Generic()
        }) { }
    }
}