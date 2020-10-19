using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiTdpProjectMemberGetbyprojectResponse.
    /// </summary>
    public class OapiTdpProjectMemberGetbyprojectResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public PageResponseDomain Result { get; set; }

	/// <summary>
/// MemberDomain Data Structure.
/// </summary>
[Serializable]

public class MemberDomain : TopObject
{
	        /// <summary>
	        /// 归属企业id
	        /// </summary>
	        [XmlElement("belong_corp_id")]
	        public string BelongCorpId { get; set; }
	
	        /// <summary>
	        /// 业务标识
	        /// </summary>
	        [XmlElement("biz_tag")]
	        public string BizTag { get; set; }
	
	        /// <summary>
	        /// 创建者id, 传staffId（工号）
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 项目成员ID
	        /// </summary>
	        [XmlElement("member_id")]
	        public string MemberId { get; set; }
	
	        /// <summary>
	        /// 更新者id, 传staffId（工号）
	        /// </summary>
	        [XmlElement("modifier_userid")]
	        public string ModifierUserid { get; set; }
	
	        /// <summary>
	        /// 成员所属空间ID
	        /// </summary>
	        [XmlElement("target_id")]
	        public string TargetId { get; set; }
	
	        /// <summary>
	        /// 成员所属空间类型
	        /// </summary>
	        [XmlElement("target_type")]
	        public string TargetType { get; set; }
	
	        /// <summary>
	        /// 用户ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// PageResponseDomain Data Structure.
/// </summary>
[Serializable]

public class PageResponseDomain : TopObject
{
	        /// <summary>
	        /// 成员列表
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("member")]
	        public List<MemberDomain> Data { get; set; }
	
	        /// <summary>
	        /// 起始页码
	        /// </summary>
	        [XmlElement("page")]
	        public long Page { get; set; }
	
	        /// <summary>
	        /// 每页数量
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
}

    }
}
