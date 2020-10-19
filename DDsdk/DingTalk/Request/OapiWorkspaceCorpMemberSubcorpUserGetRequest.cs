using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.corp.member.subcorp.user.get
    /// </summary>
    public class OapiWorkspaceCorpMemberSubcorpUserGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCorpMemberSubcorpUserGetResponse>
    {
        /// <summary>
        /// 来自于归属企业的userid列表
        /// </summary>
        public string BelongOrgUserids { get; set; }

        /// <summary>
        /// 目标组织的corpId
        /// </summary>
        public string TargetCorpId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.corp.member.subcorp.user.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("belong_org_userids", this.BelongOrgUserids);
            parameters.Add("target_corp_id", this.TargetCorpId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("belong_org_userids", this.BelongOrgUserids);
            RequestValidator.ValidateMaxListSize("belong_org_userids", this.BelongOrgUserids, 999);
            RequestValidator.ValidateRequired("target_corp_id", this.TargetCorpId);
        }

        #endregion
    }
}
