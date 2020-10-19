using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.tdp.task.basic.getbysourceid
    /// </summary>
    public class OapiTdpTaskBasicGetbysourceidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiTdpTaskBasicGetbysourceidResponse>
    {
        /// <summary>
        /// 微应用agentId
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 任务来源source
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 任务来源sourceId
        /// </summary>
        public string SourceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.tdp.task.basic.getbysourceid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("source", this.Source);
            parameters.Add("source_id", this.SourceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("source_id", this.SourceId);
        }

        #endregion
    }
}
