using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.circle.group.list
    /// </summary>
    public class OapiWorkspaceCircleGroupListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCircleGroupListResponse>
    {
        /// <summary>
        /// 分页的游标，第一页传0
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 取多少条数据，取值范围[1,20]
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.circle.group.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
