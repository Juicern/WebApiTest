using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.dtech.machine.param.list
    /// </summary>
    public class OapiRhinoDtechMachineParamListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoDtechMachineParamListResponse>
    {
        /// <summary>
        /// 工序bizid列表
        /// </summary>
        public string BizIdProcessList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.dtech.machine.param.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_id_process_list", this.BizIdProcessList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_id_process_list", this.BizIdProcessList);
            RequestValidator.ValidateMaxListSize("biz_id_process_list", this.BizIdProcessList, 20);
        }

        #endregion
    }
}
