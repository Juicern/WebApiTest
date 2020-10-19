using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPlanetomFeedsTaskinfoResponse.
    /// </summary>
    public class OapiPlanetomFeedsTaskinfoResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("upload_feed_rsp_model")]
        public List<UploadFeedRspModelDomain> Result { get; set; }

	/// <summary>
/// UploadFeedRspModelDomain Data Structure.
/// </summary>
[Serializable]

public class UploadFeedRspModelDomain : TopObject
{
	        /// <summary>
	        /// 课程处理结果
	        /// </summary>
	        [XmlElement("process_msg")]
	        public string ProcessMsg { get; set; }
	
	        /// <summary>
	        /// 结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 课程标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
