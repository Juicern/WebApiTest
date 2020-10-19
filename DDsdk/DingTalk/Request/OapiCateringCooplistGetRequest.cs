using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.cooplist.get
    /// </summary>
    public class OapiCateringCooplistGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringCooplistGetResponse>
    {
        /// <summary>
        /// 合作状态：1-申请合作 2-已合作
        /// </summary>
        public Nullable<long> CoopStatus { get; set; }

        /// <summary>
        /// 数据起始index
        /// </summary>
        public Nullable<long> OffSet { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        public Nullable<long> PgSize { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public string ShopId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.cooplist.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("coop_status", this.CoopStatus);
            parameters.Add("off_set", this.OffSet);
            parameters.Add("pg_size", this.PgSize);
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
            RequestValidator.ValidateRequired("off_set", this.OffSet);
            RequestValidator.ValidateRequired("pg_size", this.PgSize);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
        }

        #endregion
    }
}
