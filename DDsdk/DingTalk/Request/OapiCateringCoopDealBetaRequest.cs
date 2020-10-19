using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.coop.deal.beta
    /// </summary>
    public class OapiCateringCoopDealBetaRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringCoopDealBetaResponse>
    {
        /// <summary>
        /// 2同意申请，3拒绝申请，7已合作时解除合作
        /// </summary>
        public Nullable<long> CoopStatus { get; set; }

        /// <summary>
        /// 申请企业的corpId
        /// </summary>
        public string CorpEndCorpId { get; set; }

        /// <summary>
        /// 商铺id
        /// </summary>
        public string ShopId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.coop.deal.beta";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("coop_status", this.CoopStatus);
            parameters.Add("corp_end_corp_id", this.CorpEndCorpId);
            parameters.Add("shop_id", this.ShopId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("coop_status", this.CoopStatus);
            RequestValidator.ValidateRequired("corp_end_corp_id", this.CorpEndCorpId);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
        }

        #endregion
    }
}
