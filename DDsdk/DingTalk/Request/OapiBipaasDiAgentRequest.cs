using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.bipaas.di.agent
    /// </summary>
    public class OapiBipaasDiAgentRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiBipaasDiAgentResponse>
    {
        /// <summary>
        /// 请求体
        /// </summary>
        public string Request { get; set; }

        public BaseAgentRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.bipaas.di.agent";
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
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// BaseAgentRequestDomain Data Structure.
/// </summary>
[Serializable]

public class BaseAgentRequestDomain : TopObject
{
	        /// <summary>
	        /// 参数
	        /// </summary>
	        [XmlElement("params")]
	        public string Params { get; set; }
	
	        /// <summary>
	        /// 路径
	        /// </summary>
	        [XmlElement("path")]
	        public string Path { get; set; }
}

        #endregion
    }
}
