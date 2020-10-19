using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiChatThemeUpdateResponse.
    /// </summary>
    public class OapiChatThemeUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 调用成功
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
