using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.master.corpconfig.update
    /// </summary>
    public class OapiSmartworkHrmMasterCorpconfigUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmMasterCorpconfigUpdateResponse>
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        public string ScopeCode { get; set; }

        /// <summary>
        /// 企业开通状态 1:开通 2:关闭
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.master.corpconfig.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("scope_code", this.ScopeCode);
            parameters.Add("status", this.Status);
            parameters.Add("tenant_id", this.TenantId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("scope_code", this.ScopeCode);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
