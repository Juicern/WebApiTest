using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavChatSummaryGetResponse.
    /// </summary>
    public class OapiKacDatavChatSummaryGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public ImSummaryResponseDomain Result { get; set; }

	/// <summary>
/// ImSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ImSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 活跃群数（当日）
	        /// </summary>
	        [XmlElement("active_group_count")]
	        public long ActiveGroupCount { get; set; }
	
	        /// <summary>
	        /// 单聊用户数
	        /// </summary>
	        [XmlElement("chat_user_count")]
	        public long ChatUserCount { get; set; }
	
	        /// <summary>
	        /// 群聊用户数
	        /// </summary>
	        [XmlElement("group_chat_user_count")]
	        public long GroupChatUserCount { get; set; }
	
	        /// <summary>
	        /// 总群数
	        /// </summary>
	        [XmlElement("group_count")]
	        public long GroupCount { get; set; }
	
	        /// <summary>
	        /// 消息数
	        /// </summary>
	        [XmlElement("message_total_count")]
	        public long MessageTotalCount { get; set; }
	
	        /// <summary>
	        /// 聊天用户数
	        /// </summary>
	        [XmlElement("message_user_count")]
	        public long MessageUserCount { get; set; }
	
	        /// <summary>
	        /// 新增群数（当日）
	        /// </summary>
	        [XmlElement("new_group_count")]
	        public long NewGroupCount { get; set; }
}

    }
}
