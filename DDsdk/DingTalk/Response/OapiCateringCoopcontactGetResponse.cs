using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCateringCoopcontactGetResponse.
    /// </summary>
    public class OapiCateringCoopcontactGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 号码过期时间戳(毫秒)
        /// </summary>
        [XmlElement("expiration")]
        public long Expiration { get; set; }

        /// <summary>
        /// 临时隐私号
        /// </summary>
        [XmlElement("pri_mobile")]
        public string PriMobile { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
