using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCateringAllowanceCapacityGetResponse.
    /// </summary>
    public class OapiCateringAllowanceCapacityGetResponse : DingTalkResponse
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
        /// 餐补结果
        /// </summary>
        [XmlElement("result")]
        public CateringOpenGetDeductCapacityResponseDomain Result { get; set; }

	/// <summary>
/// CateringOpenGetDeductCapacityResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CateringOpenGetDeductCapacityResponseDomain : TopObject
{
	        /// <summary>
	        /// 可抵扣金额，单位为分
	        /// </summary>
	        [XmlElement("deduct_capacity")]
	        public long DeductCapacity { get; set; }
}

    }
}
