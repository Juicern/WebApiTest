using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.open.order.push
    /// </summary>
    public class OapiCateringOpenOrderPushRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringOpenOrderPushResponse>
    {
        /// <summary>
        /// 实际支付金额
        /// </summary>
        public Nullable<long> ActualAmount { get; set; }

        /// <summary>
        /// 补贴金额
        /// </summary>
        public Nullable<long> AllowanceAmount { get; set; }

        /// <summary>
        /// 补充信息
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// 餐补规则编码
        /// </summary>
        public string MealPlanNo { get; set; }

        /// <summary>
        /// 用餐时间
        /// </summary>
        public Nullable<long> MealTime { get; set; }

        /// <summary>
        /// 菜品信息
        /// </summary>
        public string OrderDetails { get; set; }

        /// <summary>
        /// 应付金额
        /// </summary>
        public Nullable<long> OrderFullAmount { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 点餐时间
        /// </summary>
        public Nullable<long> OrderTime { get; set; }

        /// <summary>
        /// 点餐商户编号
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// 点餐商家名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 点餐人姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 点餐人的编码，通过开放平台获取的 userId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.open.order.push";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("actual_amount", this.ActualAmount);
            parameters.Add("allowance_amount", this.AllowanceAmount);
            parameters.Add("ext", this.Ext);
            parameters.Add("meal_plan_no", this.MealPlanNo);
            parameters.Add("meal_time", this.MealTime);
            parameters.Add("order_details", this.OrderDetails);
            parameters.Add("order_full_amount", this.OrderFullAmount);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("order_time", this.OrderTime);
            parameters.Add("shop_id", this.ShopId);
            parameters.Add("shop_name", this.ShopName);
            parameters.Add("user_name", this.UserName);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("actual_amount", this.ActualAmount);
            RequestValidator.ValidateRequired("allowance_amount", this.AllowanceAmount);
            RequestValidator.ValidateRequired("meal_plan_no", this.MealPlanNo);
            RequestValidator.ValidateRequired("order_details", this.OrderDetails);
            RequestValidator.ValidateRequired("order_full_amount", this.OrderFullAmount);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
