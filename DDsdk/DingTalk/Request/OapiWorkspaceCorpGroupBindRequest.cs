using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.corp.group.bind
    /// </summary>
    public class OapiWorkspaceCorpGroupBindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCorpGroupBindResponse>
    {
        /// <summary>
        /// 群列表，只允许运营主体或归属企业的未绑定过的内部群
        /// </summary>
        public string ChatIds { get; set; }

        /// <summary>
        /// 目标组织id
        /// </summary>
        public string TargetCorpId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.corp.group.bind";
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
