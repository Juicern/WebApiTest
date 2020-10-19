using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.circle.group.create
    /// </summary>
    public class OapiWorkspaceCircleGroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCircleGroupCreateResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Req { get; set; }

        public OpenCreateGroupRequestDtoDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.circle.group.create";
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
/// OpenCreateGroupRequestDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCreateGroupRequestDtoDomain : TopObject
{
	        /// <summary>
	        /// 群名称，长度[3,20]字符
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 创建人，在圈子内的userid，这个人会成为群主。当圈子群超过100个时会禁止新建
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
