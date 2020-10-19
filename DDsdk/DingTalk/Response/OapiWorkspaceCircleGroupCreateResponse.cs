using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceCircleGroupCreateResponse.
    /// </summary>
    public class OapiWorkspaceCircleGroupCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("result")]
        public OpenCreateGroupResponseDtoDomain Result { get; set; }

	/// <summary>
/// OpenCreateGroupResponseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCreateGroupResponseDtoDomain : TopObject
{
	        /// <summary>
	        /// 群id
	        /// </summary>
	        [XmlElement("conversation_id")]
	        public string ConversationId { get; set; }
}

    }
}
