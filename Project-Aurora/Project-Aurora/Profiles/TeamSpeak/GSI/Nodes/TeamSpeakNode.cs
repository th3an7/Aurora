using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.TeamSpeak.GSI.Nodes
{
    public class data : Node<data>
    {

        public onConnectStatusChangeEventNode onConnectStatusChangeEvent;
        public onClientMoveEventNode onClientMoveEvent;
        public onClientKickFromChannelEventNode onClientKickFromChannelEvent;
        public onClientKickFromServerEventNode onClientKickFromServerEvent;
        public onClientPokeEventNode onClientPokeEvent;
        public onTextMessageEventNode onTextMessageEvent;
        public onTalkStatusChangeEventNode onTalkStatusChangeEvent;
        public onClientSelfVariableUpdateEventNode onClientSelfVariableUpdateEvent;

        internal data(string json) : base(json)
        {

            onConnectStatusChangeEvent = new onConnectStatusChangeEventNode(_ParsedData["onConnectStatusChangeEvent"]?.ToString() ?? "");
            onClientMoveEvent = new onClientMoveEventNode(_ParsedData["onClientMoveEvent"]?.ToString() ?? "");
            onClientKickFromChannelEvent = new onClientKickFromChannelEventNode(_ParsedData["onClientKickFromChannelEvent"]?.ToString() ?? "");
            onClientKickFromServerEvent = new onClientKickFromServerEventNode(_ParsedData["onClientKickFromServerEvent"]?.ToString() ?? "");
            onClientPokeEvent = new onClientPokeEventNode(_ParsedData["onClientPokeEvent"]?.ToString() ?? "");
            onTextMessageEvent = new onTextMessageEventNode(_ParsedData["onTextMessageEvent"]?.ToString() ?? "");
            onTalkStatusChangeEvent = new onTalkStatusChangeEventNode(_ParsedData["onTalkStatusChangeEvent"]?.ToString() ?? "");
            onClientSelfVariableUpdateEvent = new onClientSelfVariableUpdateEventNode(_ParsedData["onClientSelfVariableUpdateEvent"]?.ToString() ?? "");

        }

    }

    public class onConnectStatusChangeEventNode : Node<onConnectStatusChangeEventNode>
    {
        public int serverConnectionHandlerID;
        public int newStatus;
        public int errorNumber;

        internal onConnectStatusChangeEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }

    public class onClientMoveEventNode : Node<onClientMoveEventNode>
    {
        public int serverConnectionHandlerID;
        public int clientID;
        public int oldChannelID;
        public int newChannelID;
        public int visibility;
        public string moveMessage;

        internal onClientMoveEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }

    public class onClientKickFromChannelEventNode : Node<onClientKickFromChannelEventNode>
    {
        public int serverConnectionHandlerID;
        public int clientID;
        public int oldChannelID;
        public int newChannelID;
        public int visibility;
        public int kickerID;
        public string kickerName;
        public string kickerUniqueIdentifier;
        public string kickMessage;

        internal onClientKickFromChannelEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }

    public class onClientKickFromServerEventNode : Node<onClientKickFromServerEventNode>
    {
        public int serverConnectionHandlerID;
        public int clientID;
        public int oldChannelID;
        public int newChannelID;
        public int visibility;
        public int kickerID;
        public string kickerName;
        public string kickerUniqueIdentifier;
        public string kickMessage;

        internal onClientKickFromServerEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }

    public class onClientPokeEventNode : Node<onClientPokeEventNode>
    {
        public int serverConnectionHandlerID;
        public int fromClientID;
        public string pokerName;
        public string pokerUniqueIdentity;
        public string message;
        public int ffIgnored;

        internal onClientPokeEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }

    public class onTextMessageEventNode : Node<onTextMessageEventNode>
    {
        public int serverConnectionHandlerID;
        public int toID;
        public string fromName;
        public string fromUniqueID;
        public string message;
        public int ffIgnored;

        internal onTextMessageEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }

    public class onTalkStatusChangeEventNode : Node<onTalkStatusChangeEventNode>
    {
        public int serverConnectionHandlerID;
        public int status;
        public int isReceivedWhisper;
        public string clientID;
        public string name;

        internal onTalkStatusChangeEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }

    public class onClientSelfVariableUpdateEventNode : Node<onClientSelfVariableUpdateEventNode>
    {
        public int serverConnectionHandlerID;
        public int flag;
        public string oldValue;
        public string newValue;

        internal onClientSelfVariableUpdateEventNode(string json) : base(json)
        {
            //This code snippet was made by SnakePin
            List<System.Reflection.FieldInfo> b = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.GetFields().ToList();
            foreach (var a in b)
            {
                if (a.FieldType == typeof(System.String))
                {
                    a.SetValue(this, GetString(a.Name));
                }
                else if (a.FieldType == typeof(int))
                {
                    a.SetValue(this, GetInt(a.Name));
                }
            }
        }
    }


}
