using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.tdp.project.member.getbyproject
    /// </summary>
    public class OapiTdpProjectMemberGetbyprojectRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiTdpProjectMemberGetbyprojectResponse>
    {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> MicroappAgentId { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string PageRequest { get; set; }

        public PageRequestDomain PageRequest_ { set { this.PageRequest = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ProjectId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.tdp.project.member.getbyproject";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("microapp_agent_id", this.MicroappAgentId);
            parameters.Add("page_request", this.PageRequest);
            parameters.Add("project_id", this.ProjectId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("project_id", this.ProjectId);
        }

	/// <summary>
/// PageRequestDomain Data Structure.
/// </summary>
[Serializable]

public class PageRequestDomain : TopObject
{
	        /// <summary>
	        /// 排序字段
	        /// </summary>
	        [XmlElement("order_by")]
	        public string OrderBy { get; set; }
	
	        /// <summary>
	        /// 排序方向
	        /// </summary>
	        [XmlElement("order_direction")]
	        public string OrderDirection { get; set; }
	
	        /// <summary>
	        /// 起始页码
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 每页数量
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
