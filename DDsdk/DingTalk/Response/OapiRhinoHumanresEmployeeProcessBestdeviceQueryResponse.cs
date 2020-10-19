using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoHumanresEmployeeProcessBestdeviceQueryResponse.
    /// </summary>
    public class OapiRhinoHumanresEmployeeProcessBestdeviceQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 返回文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 额外返回信息
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [XmlElement("hsfcode")]
        public long Hsfcode { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("employee_process_device_capacity_dto")]
        public List<EmployeeProcessDeviceCapacityDtoDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// EmployeeProcessDeviceCapacityDtoDomain Data Structure.
/// </summary>
[Serializable]

public class EmployeeProcessDeviceCapacityDtoDomain : TopObject
{
	        /// <summary>
	        /// 设备型号id
	        /// </summary>
	        [XmlElement("device_model_id")]
	        public string DeviceModelId { get; set; }
	
	        /// <summary>
	        /// 设备型号版本
	        /// </summary>
	        [XmlElement("device_model_version")]
	        public string DeviceModelVersion { get; set; }
	
	        /// <summary>
	        /// 结构化工序id
	        /// </summary>
	        [XmlElement("process_capacity_id")]
	        public long ProcessCapacityId { get; set; }
	
	        /// <summary>
	        /// 生产次数
	        /// </summary>
	        [XmlElement("production_quantity")]
	        public long ProductionQuantity { get; set; }
	
	        /// <summary>
	        /// 租户
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("work_no")]
	        public string WorkNo { get; set; }
}

    }
}
