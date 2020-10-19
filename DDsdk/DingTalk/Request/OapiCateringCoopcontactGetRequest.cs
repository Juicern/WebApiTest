using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.coopcontact.get
    /// </summary>
    public class OapiCateringCoopcontactGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringCoopcontactGetResponse>
    {
        /// <summary>
        /// 呼叫方的userId
        /// </summary>
        public string CallerUserid { get; set; }

        /// <summary>
        /// 合作企业的corpId
        /// </summary>
        public string CorpEndCorpId { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public string ShopId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.coopcontact.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("caller_userid", this.CallerUserid);
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
            RequestValidator.ValidateRequired("caller_userid", this.CallerUserid);
            RequestValidator.ValidateRequired("corp_end_corp_id", this.CorpEndCorpId);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
        }

        #endregion
    }
}
