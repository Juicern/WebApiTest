using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.master.check
    /// </summary>
    public class OapiSmartworkHrmMasterCheckRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmMasterCheckResponse>
    {
        /// <summary>
        /// 业务UK唯一确定一条流水
        /// </summary>
        public string BizUk { get; set; }

        /// <summary>
        /// 业务方id(由系统统一分配)
        /// </summary>
        public Nullable<long> Tenantid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.master.check";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_uk", this.BizUk);
            parameters.Add("tenantid", this.Tenantid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_uk", this.BizUk);
            RequestValidator.ValidateMaxListSize("biz_uk", this.BizUk, 20);
            RequestValidator.ValidateRequired("tenantid", this.Tenantid);
        }

        #endregion
    }
}
