using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.procmanager.save
    /// </summary>
    public class OapiProcessProcmanagerSaveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessProcmanagerSaveResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Request { get; set; }

        public UpdateProcessManagersRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.procmanager.save";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
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
/// UpdateProcessManagersRequestDomain Data Structure.
/// </summary>
[Serializable]

public class UpdateProcessManagersRequestDomain : TopObject
{
	        /// <summary>
	        /// 企业应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 管理员列表
	        /// </summary>
	        [XmlArray("manager_list")]
	        [XmlArrayItem("string")]
	        public List<string> ManagerList { get; set; }
	
	        /// <summary>
	        /// 流程模板processCode
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 操作人userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
