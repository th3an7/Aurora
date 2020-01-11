using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.Spotify.GSI.Nodes
{
    public class ColorsNode : Node<ColorsNode>
    {

        public string Desaturated = String.Empty;
        public string LightVibrant = String.Empty;
        public string Prominent = String.Empty;
        public string Vibrant = String.Empty;
        public string VibrantNotAlarming = String.Empty;


        internal ColorsNode() : base() { }
        internal ColorsNode(string json) : base(json)
        {
            Desaturated = GetString("desaturated");
            LightVibrant = GetString("light_vibrant");
            Prominent = GetString("prominent");
            Vibrant = GetString("vibrant");
            VibrantNotAlarming = GetString("vibrant_not_alarming");
        }
    }
}
