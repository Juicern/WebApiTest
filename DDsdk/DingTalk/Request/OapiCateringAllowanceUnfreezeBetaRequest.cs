using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.allowance.unfreeze.beta
    /// </summary>
    public class OapiCateringAllowanceUnfreezeBetaRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringAllowanceUnfreezeBetaResponse>
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 餐补规则编码
        /// </summary>
        public string RuleCode { get; set; }

        /// <summary>
        /// 点餐人userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.allowance.unfreeze.beta";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("order_id", this.OrderId);
            parameters.Add("rule_code", this.RuleCode);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("rule_code", this.RuleCode);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
