using Aurora.Profiles.Spotify.GSI.Nodes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.Spotify.GSI
{
    public class GameState_Spotify : GameState<GameState_Spotify>
    {

        private ProviderNode _Provider;
        private PlayerNode _Player;
        private ColorsNode _Colors;


        public ProviderNode Provider
        {
            get
            {
                if (_Provider == null)
                    _Provider = new ProviderNode(_ParsedData["provider"]?.ToString() ?? "");
                return _Provider;
            }
        }

        public PlayerNode Player
        {
            get
            {
                if (_Player == null)
                    _Player = new PlayerNode(_ParsedData["player"]?.ToString() ?? "");
                return _Player;
            }
        }

        public ColorsNode Colors
        {
            get
            {
                if (_Colors == null)
                    _Colors = new ColorsNode(_ParsedData["colors"]?.ToString() ?? "");
                return _Colors;
            }
        }



        public GameState_Spotify() : base() { }

        public GameState_Spotify(string JSONstring) : base(JSONstring) { }

        public GameState_Spotify(IGameState other) : base(other) { }
    }
}