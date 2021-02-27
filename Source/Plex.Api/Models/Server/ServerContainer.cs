﻿namespace Plex.Api.Models.Server
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Server Container Object
    /// </summary>
    [XmlRoot(ElementName = "MediaContainer")]
    public class ServerContainer
    {
        /// <summary>
        /// Server Items
        /// </summary>
        [XmlElement(ElementName = "Server")]
        public List<Server> Servers { get; set; }

        /// <summary>
        /// Friendly Name
        /// </summary>
        [XmlAttribute(AttributeName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        [XmlAttribute(AttributeName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Machine Identifier
        /// </summary>
        [XmlAttribute(AttributeName = "machineIdentifier")]
        public string MachineIdentifier { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }
    }
}
