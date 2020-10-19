using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoCooperationCarrierGetResponse.
    /// </summary>
    public class OapiRhinoCooperationCarrierGetResponse : DingTalkResponse
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
        /// 扩展信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("model")]
        public CarrierDtoDomain Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CarrierDtoDomain Data Structure.
/// </summary>
[Serializable]

public class CarrierDtoDomain : TopObject
{
	        /// <summary>
	        /// 载具code
	        /// </summary>
	        [XmlElement("carrier_code")]
	        public string CarrierCode { get; set; }
	
	        /// <summary>
	        /// 载具id
	        /// </summary>
	        [XmlElement("carrier_id")]
	        public long CarrierId { get; set; }
	
	        /// <summary>
	        /// 载具名称
	        /// </summary>
	        [XmlElement("carrier_name")]
	        public string CarrierName { get; set; }
	
	        /// <summary>
	        /// 载具类型
	        /// </summary>
	        [XmlElement("carrier_type")]
	        public long CarrierType { get; set; }
	
	        /// <summary>
	        /// 载具类型名称
	        /// </summary>
	        [XmlElement("carrier_type_name")]
	        public string CarrierTypeName { get; set; }
	
	        /// <summary>
	        /// 是否可用
	        /// </summary>
	        [XmlElement("enabled")]
	        public bool Enabled { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
}

    }
}
