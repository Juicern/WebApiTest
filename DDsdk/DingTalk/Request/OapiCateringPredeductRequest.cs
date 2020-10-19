using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.prededuct
    /// </summary>
    public class OapiCateringPredeductRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringPredeductResponse>
    {
        /// <summary>
        /// 抵扣部分金额的超时时间（毫秒）
        /// </summary>
        public Nullable<long> ExpiryTime { get; set; }

        /// <summary>
        /// 用餐时间
        /// </summary>
        public Nullable<long> MealTime { get; set; }

        /// <summary>
        /// 应付金额
        /// </summary>
        public Nullable<long> OrderFullAmount { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        public string Orderid { get; set; }

        /// <summary>
        /// 点餐人userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.prededuct";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("expiry_time", this.ExpiryTime);
            parameters.Add("meal_time", this.MealTime);
            parameters.Add("order_full_amount", this.OrderFullAmount);
            parameters.Add("orderid", this.Orderid);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("expiry_time", this.ExpiryTime);
            RequestValidator.ValidateRequired("meal_time", this.MealTime);
            RequestValidator.ValidateRequired("order_full_amount", this.OrderFullAmount);
            RequestValidator.ValidateRequired("orderid", this.Orderid);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
