using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoHumanresEmployeeProcessCapacityQueryResponse.
    /// </summary>
    public class OapiRhinoHumanresEmployeeProcessCapacityQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("externalMsgInfo")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// 返回code
        /// </summary>
        [XmlElement("hsfcode")]
        public long Hsfcode { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("employee_process_capacity_statistic_dto")]
        public List<EmployeeProcessCapacityStatisticDtoDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// EmployeeProcessCapacityStatisticDtoDomain Data Structure.
/// </summary>
[Serializable]

public class EmployeeProcessCapacityStatisticDtoDomain : TopObject
{
	        /// <summary>
	        /// 订单品类
	        /// </summary>
	        [XmlElement("category")]
	        public string Category { get; set; }
	
	        /// <summary>
	        /// 工序技能id
	        /// </summary>
	        [XmlElement("process_capacity_id")]
	        public long ProcessCapacityId { get; set; }
	
	        /// <summary>
	        /// 结构化工序id
	        /// </summary>
	        [XmlElement("process_structural_cluster_id")]
	        public long ProcessStructuralClusterId { get; set; }
	
	        /// <summary>
	        /// 经验值
	        /// </summary>
	        [XmlElement("production_quantity")]
	        public long ProductionQuantity { get; set; }
	
	        /// <summary>
	        /// 统计类型
	        /// </summary>
	        [XmlElement("statistic_category")]
	        public long StatisticCategory { get; set; }
	
	        /// <summary>
	        /// 统计值
	        /// </summary>
	        [XmlElement("statistics_value")]
	        public string StatisticsValue { get; set; }
	
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
