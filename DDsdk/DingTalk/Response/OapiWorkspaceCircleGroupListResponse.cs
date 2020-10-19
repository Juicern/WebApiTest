using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceCircleGroupListResponse.
    /// </summary>
    public class OapiWorkspaceCircleGroupListResponse : DingTalkResponse
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
        public OpenQueryGroupResponseDtoDomain Result { get; set; }

	/// <summary>
/// OpenGroupDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGroupDtoDomain : TopObject
{
	        /// <summary>
	        /// 群头像mediaId，需要再调用开放平台官网提供的接口转成http地址
	        /// </summary>
	        [XmlElement("avatar_media_id")]
	        public string AvatarMediaId { get; set; }
	
	        /// <summary>
	        /// 群id
	        /// </summary>
	        [XmlElement("conversation_id")]
	        public string ConversationId { get; set; }
	
	        /// <summary>
	        /// 当前人数
	        /// </summary>
	        [XmlElement("member_count")]
	        public long MemberCount { get; set; }
	
	        /// <summary>
	        /// 群人数上限
	        /// </summary>
	        [XmlElement("member_limit")]
	        public long MemberLimit { get; set; }
	
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenQueryGroupResponseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenQueryGroupResponseDtoDomain : TopObject
{
	        /// <summary>
	        /// 圈子群列表
	        /// </summary>
	        [XmlArray("groups")]
	        [XmlArrayItem("open_group_dto")]
	        public List<OpenGroupDtoDomain> Groups { get; set; }
	
	        /// <summary>
	        /// 是否有更多数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次分页的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
