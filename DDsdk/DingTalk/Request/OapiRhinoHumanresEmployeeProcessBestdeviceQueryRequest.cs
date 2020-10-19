using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.humanres.employee.process.bestdevice.query
    /// </summary>
    public class OapiRhinoHumanresEmployeeProcessBestdeviceQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoHumanresEmployeeProcessBestdeviceQueryResponse>
    {
        /// <summary>
        /// 可用设备型号
        /// </summary>
        public string AvailableDeviceModels { get; set; }

        public List<DeviceModelDtoDomain> AvailableDeviceModels_ { set { this.AvailableDeviceModels = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 人员工序关系
        /// </summary>
        public string EmployeeProcessCapacityUnits { get; set; }

        public List<EmployeeProcessCapacityUnitReqDomain> EmployeeProcessCapacityUnits_ { set { this.EmployeeProcessCapacityUnits = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 租户
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.humanres.employee.process.bestdevice.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("available_device_models", this.AvailableDeviceModels);
            parameters.Add("employee_process_capacity_units", this.EmployeeProcessCapacityUnits);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("available_device_models", this.AvailableDeviceModels, 20);
            RequestValidator.ValidateObjectMaxListSize("employee_process_capacity_units", this.EmployeeProcessCapacityUnits, 20);
        }

	/// <summary>
/// DeviceModelDtoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceModelDtoDomain : TopObject
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
}

	/// <summary>
/// EmployeeProcessCapacityUnitReqDomain Data Structure.
/// </summary>
[Serializable]

public class EmployeeProcessCapacityUnitReqDomain : TopObject
{
	        /// <summary>
	        /// 结构化工序id
	        /// </summary>
	        [XmlElement("process_capacity_id")]
	        public Nullable<long> ProcessCapacityId { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("work_no")]
	        public string WorkNo { get; set; }
}

        #endregion
    }
}
