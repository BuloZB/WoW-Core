﻿// Copyright (c) Arctium Emulation.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace Framework.Remoting.Objects
{
    [DataContract]
    [KnownType(typeof(CharacterServerInfo))]
    [KnownType(typeof(WorldServerInfo))]
    [KnownType(typeof(WorldNodeInfo))]
    public abstract class ServerInfoBase
    {
        [DataMember]
        public uint SessionId         { get; set; }
        [DataMember]
        public uint RealmId           { get; set; }
        [DataMember]
        public string IPAddress       { get; set; }
        [DataMember]
        public ushort Port            { get; set; }
        [DataMember]
        public uint ActiveConnections { get; set; }

        public bool Compare(ServerInfoBase info)
        {
            return RealmId == info.RealmId && IPAddress == info.IPAddress && Port == info.Port;
        }
    }
}
