using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurora.Profiles.TeamSpeak.GSI.Nodes;

namespace Aurora.Profiles.TeamSpeak.GSI
{
    public class GameState_TeamSpeak : GameState<GameState_TeamSpeak>
    {
        private ProviderNode _Provider;
        private data _GameState;

        public ProviderNode Provider
        {
            get
            {
                if (_Provider == null)
                    _Provider = new ProviderNode(_ParsedData["provider"]?.ToString() ?? "");
                return _Provider;
            }
        }

        public data GameState
        {
            get
            {
                if (_GameState == null)
                    _GameState = new data(_ParsedData["data"]?.ToString() ?? "");

                return _GameState;
            }
        }

        public GameState_TeamSpeak() : base() { }

        public GameState_TeamSpeak(string JSONstring) : base(JSONstring) { }

        public GameState_TeamSpeak(IGameState other) : base(other) { }
    }
}
