using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoDtechMachineParamListResponse.
    /// </summary>
    public class OapiRhinoDtechMachineParamListResponse : DingTalkResponse
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
	        /// 设备参数bizid
	        /// </summary>
	        [XmlElement("biz_id_machine_param")]
	        public string BizIdMachineParam { get; set; }
	
	        /// <summary>
	        /// 工序bizid
	        /// </summary>
	        [XmlElement("biz_id_process")]
	        public string BizIdProcess { get; set; }
	
	        /// <summary>
	        /// 描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 设备编码
	        /// </summary>
	        [XmlElement("machine_code")]
	        public string MachineCode { get; set; }
	
	        /// <summary>
	        /// 设备名称
	        /// </summary>
	        [XmlElement("machine_name")]
	        public string MachineName { get; set; }
	
	        /// <summary>
	        /// 版本
	        /// </summary>
	        [XmlElement("machine_version")]
	        public string MachineVersion { get; set; }
	
	        /// <summary>
	        /// 设备名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// 参数值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

    }
}
