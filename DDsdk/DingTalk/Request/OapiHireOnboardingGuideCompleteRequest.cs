using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.hire.onboarding.guide.complete
    /// </summary>
    public class OapiHireOnboardingGuideCompleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiHireOnboardingGuideCompleteResponse>
    {
        /// <summary>
        /// 引导步骤名称
        /// </summary>
        public string GuideName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.hire.onboarding.guide.complete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("guide_name", this.GuideName);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("guide_name", this.GuideName);
        }

        #endregion
    }
}
