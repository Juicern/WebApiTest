using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.corp.group.unbind
    /// </summary>
    public class OapiWorkspaceCorpGroupUnbindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCorpGroupUnbindResponse>
    {
        /// <summary>
        /// 要解绑的群，必须是当前组织的内部群
        /// </summary>
        public string ChatIds { get; set; }

        /// <summary>
        /// 目标组织
        /// </summary>
        public string TargetCorpId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.corp.group.unbind";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chat_ids", this.ChatIds);
            parameters.Add("target_corp_id", this.TargetCorpId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chat_ids", this.ChatIds);
            RequestValidator.ValidateMaxListSize("chat_ids", this.ChatIds, 20);
            RequestValidator.ValidateRequired("target_corp_id", this.TargetCorpId);
        }

        #endregion
    }
}
