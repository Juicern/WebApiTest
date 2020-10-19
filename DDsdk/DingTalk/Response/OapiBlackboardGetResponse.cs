using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiBlackboardGetResponse.
    /// </summary>
    public class OapiBlackboardGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 请求失败返回错误码，0代表无错误
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 请求失败返回错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 出参，success为true时，该值不为空，否则值为空
        /// </summary>
        [XmlElement("result")]
        public OapiBlackboardVoDomain Result { get; set; }

        /// <summary>
        /// 本次调用是否成功，该值为false时，根据errcode和errMsg排查失败原因
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OapiBlackboardVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiBlackboardVoDomain : TopObject
{
	        /// <summary>
	        /// 公告作者
	        /// </summary>
	        [XmlElement("author")]
	        public string Author { get; set; }
	
	        /// <summary>
	        /// 公告分类
	        /// </summary>
	        [XmlElement("category_id")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 公告内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 封面图的url链接
	        /// </summary>
	        [XmlElement("coverpic_url")]
	        public string CoverpicUrl { get; set; }
	
	        /// <summary>
	        /// 接收部门列表
	        /// </summary>
	        [XmlArray("depname_list")]
	        [XmlArrayItem("string")]
	        public List<string> DepnameList { get; set; }
	
	        /// <summary>
	        /// 公告创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 公告最后修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 公告id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 保密等级(0：普通公告，20：保密公告)
	        /// </summary>
	        [XmlElement("private_level")]
	        public long PrivateLevel { get; set; }
	
	        /// <summary>
	        /// 已读人数
	        /// </summary>
	        [XmlElement("read_count")]
	        public long ReadCount { get; set; }
	
	        /// <summary>
	        /// 公告标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 未读人数
	        /// </summary>
	        [XmlElement("unread_count")]
	        public long UnreadCount { get; set; }
	
	        /// <summary>
	        /// 接收人列表
	        /// </summary>
	        [XmlArray("username_list")]
	        [XmlArrayItem("string")]
	        public List<string> UsernameList { get; set; }
}

    }
}
