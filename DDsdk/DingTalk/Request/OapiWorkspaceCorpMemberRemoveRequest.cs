using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.corp.member.remove
    /// </summary>
    public class OapiWorkspaceCorpMemberRemoveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCorpMemberRemoveResponse>
    {
        /// <summary>
        /// 目标组织id
        /// </summary>
        public string TargetCorpId { get; set; }

        /// <summary>
        /// 目标成员
        /// </summary>
        public string Userids { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.corp.member.remove";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("target_corp_id", this.TargetCorpId);
            parameters.Add("userids", this.Userids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("target_corp_id", this.TargetCorpId);
            RequestValidator.ValidateRequired("userids", this.Userids);
            RequestValidator.ValidateMaxListSize("userids", this.Userids, 20);
        }

        #endregion
    }
}
