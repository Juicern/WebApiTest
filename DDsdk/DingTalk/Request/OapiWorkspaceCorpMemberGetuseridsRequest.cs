using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.corp.member.getuserids
    /// </summary>
    public class OapiWorkspaceCorpMemberGetuseridsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCorpMemberGetuseridsResponse>
    {
        /// <summary>
        /// 小圈corpId
        /// </summary>
        public string SourceCorpId { get; set; }

        /// <summary>
        /// 小圈的userid列表
        /// </summary>
        public string Userids { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.corp.member.getuserids";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("source_corp_id", this.SourceCorpId);
            parameters.Add("userids", this.Userids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("source_corp_id", this.SourceCorpId);
            RequestValidator.ValidateRequired("userids", this.Userids);
            RequestValidator.ValidateMaxListSize("userids", this.Userids, 20);
        }

        #endregion
    }
}
