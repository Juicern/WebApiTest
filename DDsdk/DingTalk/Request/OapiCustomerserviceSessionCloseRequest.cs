using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.session.close
    /// </summary>
    public class OapiCustomerserviceSessionCloseRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceSessionCloseResponse>
    {
        /// <summary>
        /// 关闭会话
        /// </summary>
        public string CloseSession { get; set; }

        public CloseSessionDTODomain CloseSession_ { set { this.CloseSession = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.session.close";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("close_session", this.CloseSession);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("close_session", this.CloseSession);
        }

	/// <summary>
/// CloseSessionDTODomain Data Structure.
/// </summary>
[Serializable]

public class CloseSessionDTODomain : TopObject
{
	        /// <summary>
	        /// 客服所在bu
	        /// </summary>
	        [XmlElement("bu_id")]
	        public string BuId { get; set; }
	
	        /// <summary>
	        /// 操作者id
	        /// </summary>
	        [XmlElement("operator_id")]
	        public string OperatorId { get; set; }
	
	        /// <summary>
	        /// 关闭原因，memberIsSilent/heartBeatBreak/memberCloseTheSession
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
	
	        /// <summary>
	        /// 会话来源
	        /// </summary>
	        [XmlElement("session_source")]
	        public string SessionSource { get; set; }
	
	        /// <summary>
	        /// 会话id
	        /// </summary>
	        [XmlElement("sid")]
	        public string Sid { get; set; }
}

        #endregion
    }
}
