using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHireOnboardingGuideCompleteResponse.
    /// </summary>
    public class OapiHireOnboardingGuideCompleteResponse : DingTalkResponse
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
        /// 同步信息结果：true/false
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
