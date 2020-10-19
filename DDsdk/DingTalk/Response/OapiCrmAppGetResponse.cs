using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmAppGetResponse.
    /// </summary>
    public class OapiCrmAppGetResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public GetCrmMicroAppResponseDomain Result { get; set; }

	/// <summary>
/// GetCrmMicroAppResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GetCrmMicroAppResponseDomain : TopObject
{
	        /// <summary>
	        /// 应用AgentId
	        /// </summary>
	        [XmlElement("agentid")]
	        public long Agentid { get; set; }
	
	        /// <summary>
	        /// 微应用描述
	        /// </summary>
	        [XmlElement("app_desc")]
	        public string AppDesc { get; set; }
	
	        /// <summary>
	        /// mediaId
	        /// </summary>
	        [XmlElement("app_icon")]
	        public string AppIcon { get; set; }
	
	        /// <summary>
	        /// app账号
	        /// </summary>
	        [XmlElement("app_key")]
	        public string AppKey { get; set; }
	
	        /// <summary>
	        /// app秘钥
	        /// </summary>
	        [XmlElement("app_secret")]
	        public string AppSecret { get; set; }
	
	        /// <summary>
	        /// 业务自定义扩展key
	        /// </summary>
	        [XmlElement("biz_key")]
	        public string BizKey { get; set; }
	
	        /// <summary>
	        /// 移动端地址
	        /// </summary>
	        [XmlElement("homepage")]
	        public string Homepage { get; set; }
	
	        /// <summary>
	        /// ip_white_list
	        /// </summary>
	        [XmlElement("ip_white_list")]
	        public string IpWhiteList { get; set; }
	
	        /// <summary>
	        /// 微应用名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// pc端地址
	        /// </summary>
	        [XmlElement("pc_homepage")]
	        public string PcHomepage { get; set; }
}

    }
}
