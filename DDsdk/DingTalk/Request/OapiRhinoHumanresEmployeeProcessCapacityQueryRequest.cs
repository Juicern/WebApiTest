using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.humanres.employee.process.capacity.query
    /// </summary>
    public class OapiRhinoHumanresEmployeeProcessCapacityQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoHumanresEmployeeProcessCapacityQueryResponse>
    {
        /// <summary>
        /// 1
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string ProcessStructuralClusterIdList { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string WorkNos { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.humanres.employee.process.capacity.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category", this.Category);
            parameters.Add("process_structural_cluster_id_list", this.ProcessStructuralClusterIdList);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            parameters.Add("work_nos", this.WorkNos);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("process_structural_cluster_id_list", this.ProcessStructuralClusterIdList, 20);
            RequestValidator.ValidateMaxListSize("work_nos", this.WorkNos, 20);
        }

        #endregion
    }
}
