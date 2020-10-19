using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.tdp.project.basic.update
    /// </summary>
    public class OapiTdpProjectBasicUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiTdpProjectBasicUpdateResponse>
    {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> MicroappAgentId { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        public string OperatorUserid { get; set; }

        /// <summary>
        /// 项目信息
        /// </summary>
        public string Project { get; set; }

        public ProjectUpdateDomain Project_ { set { this.Project = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ProjectId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.tdp.project.basic.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("microapp_agent_id", this.MicroappAgentId);
            parameters.Add("operator_userid", this.OperatorUserid);
            parameters.Add("project", this.Project);
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
/// ProjectUpdateDomain Data Structure.
/// </summary>
[Serializable]

public class ProjectUpdateDomain : TopObject
{
	        /// <summary>
	        /// 项目描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public Nullable<DateTime> GmtModified { get; set; }
	
	        /// <summary>
	        /// 项目图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 项目类型
	        /// </summary>
	        [XmlElement("identifier")]
	        public string Identifier { get; set; }
	
	        /// <summary>
	        /// 是否归档
	        /// </summary>
	        [XmlElement("is_archived")]
	        public Nullable<bool> IsArchived { get; set; }
	
	        /// <summary>
	        /// 是否放入回收站
	        /// </summary>
	        [XmlElement("is_recycled")]
	        public Nullable<bool> IsRecycled { get; set; }
	
	        /// <summary>
	        /// 更新者id, 传staffId（工号）
	        /// </summary>
	        [XmlElement("modifier_userid")]
	        public string ModifierUserid { get; set; }
	
	        /// <summary>
	        /// 项目名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 父项目ID
	        /// </summary>
	        [XmlElement("parent_id")]
	        public string ParentId { get; set; }
	
	        /// <summary>
	        /// 项目可见范围
	        /// </summary>
	        [XmlElement("visibility")]
	        public string Visibility { get; set; }
}

        #endregion
    }
}
