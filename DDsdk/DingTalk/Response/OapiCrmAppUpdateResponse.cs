using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmAppUpdateResponse.
    /// </summary>
    public class OapiCrmAppUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// GetCrmMicroAppResponse
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
	        /// agentid
	        /// </summary>
	        [XmlElement("agentid")]
	        public long Agentid { get; set; }
	
	        /// <summary>
	        /// app_desc
	        /// </summary>
	        [XmlElement("app_desc")]
	        public string AppDesc { get; set; }
	
	        /// <summary>
	        /// app_icon
	        /// </summary>
	        [XmlElement("app_icon")]
	        public string AppIcon { get; set; }
	
	        /// <summary>
	        /// app_key
	        /// </summary>
	        [XmlElement("app_key")]
	        public string AppKey { get; set; }
	
	        /// <summary>
	        /// app_secret
	        /// </summary>
	        [XmlElement("app_secret")]
	        public string AppSecret { get; set; }
	
	        /// <summary>
	        /// crm_dsb
	        /// </summary>
	        [XmlElement("biz_key")]
	        public string BizKey { get; set; }
	
	        /// <summary>
	        /// homepage
	        /// </summary>
	        [XmlElement("homepage")]
	        public string Homepage { get; set; }
	
	        /// <summary>
	        /// ip_white_list
	        /// </summary>
	        [XmlElement("ip_white_list")]
	        public string IpWhiteList { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// pc_homepage
	        /// </summary>
	        [XmlElement("pc_homepage")]
	        public string PcHomepage { get; set; }
}

    }
}
