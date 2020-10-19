using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.class.listbyteacher
    /// </summary>
    public class OapiEduClassListbyteacherRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduClassListbyteacherResponse>
    {
        /// <summary>
        /// 过滤入参
        /// </summary>
        public string FilterParam { get; set; }

        public OpenClassParamDomain FilterParam_ { set { this.FilterParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.class.listbyteacher";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("filter_param", this.FilterParam);
            parameters.Add("userid", this.Userid);
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
/// OpenClassParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenClassParamDomain : TopObject
{
	        /// <summary>
	        /// 群类型
	        /// </summary>
	        [XmlElement("group_type")]
	        public string GroupType { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
}

        #endregion
    }
}
