using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.TeamSpeak.GSI.Nodes {
    public class ProviderNode : Node<ProviderNode>
    {
        public string Name;
        public string AppID;

        internal ProviderNode(string json) : base(json)
        {
            AppID = GetString("appid");
            Name = GetString("name");
        }
    }
}
