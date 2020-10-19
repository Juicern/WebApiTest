using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.humanres.process.structural.cluster.query
    /// </summary>
    public class OapiRhinoHumanresProcessStructuralClusterQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoHumanresProcessStructuralClusterQueryResponse>
    {
        /// <summary>
        /// 1
        /// </summary>
        public string BizIdProcessList { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.humanres.process.structural.cluster.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id_process_list", this.BizIdProcessList);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("biz_id_process_list", this.BizIdProcessList, 20);
        }

        #endregion
    }
}
