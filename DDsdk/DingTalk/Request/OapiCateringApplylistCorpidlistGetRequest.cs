using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.applylist.corpidlist.get
    /// </summary>
    public class OapiCateringApplylistCorpidlistGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringApplylistCorpidlistGetResponse>
    {
        /// <summary>
        /// 店铺id列表
        /// </summary>
        public string ShopIdList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.applylist.corpidlist.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("shop_id_list", this.ShopIdList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("shop_id_list", this.ShopIdList);
            RequestValidator.ValidateMaxListSize("shop_id_list", this.ShopIdList, 20);
        }

        #endregion
    }
}
