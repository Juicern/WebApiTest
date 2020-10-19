using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.personalorder.push
    /// </summary>
    public class OapiCateringPersonalorderPushRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringPersonalorderPushResponse>
    {
        /// <summary>
        /// 实收总额(分)
        /// </summary>
        public Nullable<long> FeeActuallyPay { get; set; }

        /// <summary>
        /// 折后费用(分)
        /// </summary>
        public Nullable<long> FeeAfterDiscount { get; set; }

        /// <summary>
        /// 原始费用(分)
        /// </summary>
        public Nullable<long> FeeOriginal { get; set; }

        /// <summary>
        /// 应付总额(分)
        /// </summary>
        public Nullable<long> FeeShouldPay { get; set; }

        /// <summary>
        /// 订单详情
        /// </summary>
        public string OrderDetails { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        public Nullable<DateTime> PaymentTime { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.personalorder.push";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fee_actually_pay", this.FeeActuallyPay);
            parameters.Add("fee_after_discount", this.FeeAfterDiscount);
            parameters.Add("fee_original", this.FeeOriginal);
            parameters.Add("fee_should_pay", this.FeeShouldPay);
            parameters.Add("order_details", this.OrderDetails);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("payment_time", this.PaymentTime);
            parameters.Add("shop_id", this.ShopId);
            parameters.Add("shop_name", this.ShopName);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_details", this.OrderDetails);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
        }

        #endregion
    }
}
