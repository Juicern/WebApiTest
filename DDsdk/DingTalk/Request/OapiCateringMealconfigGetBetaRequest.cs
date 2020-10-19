using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.mealconfig.get.beta
    /// </summary>
    public class OapiCateringMealconfigGetBetaRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringMealconfigGetBetaResponse>
    {
        /// <summary>
        /// 获取未来n天的可点餐时间（包括今天）如： 1， 则返回今天和明天的可点餐日期，最大值为13
        /// </summary>
        public Nullable<long> MealDayOffset { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.mealconfig.get.beta";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("meal_day_offset", this.MealDayOffset);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("meal_day_offset", this.MealDayOffset);
        }

        #endregion
    }
}
