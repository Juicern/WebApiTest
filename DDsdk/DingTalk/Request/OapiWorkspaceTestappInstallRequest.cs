using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.testapp.install
    /// </summary>
    public class OapiWorkspaceTestappInstallRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceTestappInstallResponse>
    {
        /// <summary>
        /// 为isv组织下的圈子安装测试应用
        /// </summary>
        public string InstallTestapp { get; set; }

        public AuthOpenIsvMicroAppDtoDomain InstallTestapp_ { set { this.InstallTestapp = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.testapp.install";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("install_testapp", this.InstallTestapp);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("install_testapp", this.InstallTestapp);
        }

	/// <summary>
/// AuthOpenIsvMicroAppDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AuthOpenIsvMicroAppDtoDomain : TopObject
{
	        /// <summary>
	        /// 圈子组织的corpId，圈子归属组织必须是isv组织
	        /// </summary>
	        [XmlElement("circle_corp_id")]
	        public string CircleCorpId { get; set; }
}

        #endregion
    }
}
