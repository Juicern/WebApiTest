using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoDtechProcessTypeListResponse.
    /// </summary>
    public class OapiRhinoDtechProcessTypeListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// model
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("model")]
        public List<ModelDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ModelDomain Data Structure.
/// </summary>
[Serializable]

public class ModelDomain : TopObject
{
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 工序能力编码
	        /// </summary>
	        [XmlElement("process_type_code")]
	        public string ProcessTypeCode { get; set; }
	
	        /// <summary>
	        /// 工序能力名称
	        /// </summary>
	        [XmlElement("process_type_name")]
	        public string ProcessTypeName { get; set; }
	
	        /// <summary>
	        /// 春晓工厂id
	        /// </summary>
	        [XmlElement("source_factory_id")]
	        public string SourceFactoryId { get; set; }
}

    }
}
