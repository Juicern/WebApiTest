using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCateringAllowancePredeductBetaResponse.
    /// </summary>
    public class OapiCateringAllowancePredeductBetaResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 预抵扣结果
        /// </summary>
        [XmlElement("result")]
        public CateringOpenPreDeductResponseDomain Result { get; set; }

	/// <summary>
/// CateringOpenPreDeductResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CateringOpenPreDeductResponseDomain : TopObject
{
	        /// <summary>
	        /// 已经预抵扣的金额
	        /// </summary>
	        [XmlElement("deducted_amount")]
	        public long DeductedAmount { get; set; }
	
	        /// <summary>
	        /// 餐补规则编码
	        /// </summary>
	        [XmlElement("meal_plan_no")]
	        public string MealPlanNo { get; set; }
}

    }
}
