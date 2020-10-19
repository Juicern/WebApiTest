using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.order.query
    /// </summary>
    public class OapiRhinoOrderQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoOrderQueryResponse>
    {
        /// <summary>
        /// 请求体
        /// </summary>
        public string Req { get; set; }

        public OpenApiQueryProductOrderReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.order.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("req", this.Req);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// OpenApiQueryProductOrderReqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiQueryProductOrderReqDomain : TopObject
{
	        /// <summary>
	        /// 搜索字段
	        /// </summary>
	        [XmlElement("key_word")]
	        public string KeyWord { get; set; }
	
	        /// <summary>
	        /// 分页字段，页数
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 分页字段，默认分页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 计划开始时间-查询结束时间
	        /// </summary>
	        [XmlElement("plan_time_begin")]
	        public Nullable<DateTime> PlanTimeBegin { get; set; }
	
	        /// <summary>
	        /// 计划开始时间-查询结束时间
	        /// </summary>
	        [XmlElement("plan_time_end")]
	        public Nullable<DateTime> PlanTimeEnd { get; set; }
	
	        /// <summary>
	        /// 排序字段
	        /// </summary>
	        [XmlElement("sort")]
	        public string Sort { get; set; }
	
	        /// <summary>
	        /// 是否顺序排序
	        /// </summary>
	        [XmlElement("sort_asc")]
	        public Nullable<bool> SortAsc { get; set; }
	
	        /// <summary>
	        /// 状态列表
	        /// </summary>
	        [XmlArray("status_list")]
	        [XmlArrayItem("string")]
	        public List<string> StatusList { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
