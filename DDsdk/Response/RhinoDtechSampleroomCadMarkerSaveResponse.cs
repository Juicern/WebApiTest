using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// RhinoDtechSampleroomCadMarkerSaveResponse.
    /// </summary>
    public class RhinoDtechSampleroomCadMarkerSaveResponse : TopResponse
    {
        /// <summary>
        /// content
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [XmlElement("ret_code")]
        public long RetCode { get; set; }

    }
}
