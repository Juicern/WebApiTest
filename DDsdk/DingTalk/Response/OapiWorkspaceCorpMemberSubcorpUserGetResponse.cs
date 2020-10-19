using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceCorpMemberSubcorpUserGetResponse.
    /// </summary>
    public class OapiWorkspaceCorpMemberSubcorpUserGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// userid到userid的映射
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
