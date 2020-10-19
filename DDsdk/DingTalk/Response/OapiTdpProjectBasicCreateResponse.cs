using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiTdpProjectBasicCreateResponse.
    /// </summary>
    public class OapiTdpProjectBasicCreateResponse : DingTalkResponse
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
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public ProjectDomain Result { get; set; }

	/// <summary>
/// ProjectDomain Data Structure.
/// </summary>
[Serializable]

public class ProjectDomain : TopObject
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
	        /// 项目描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
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
	        /// 项目图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 是否归档
	        /// </summary>
	        [XmlElement("is_archived")]
	        public bool IsArchived { get; set; }
	
	        /// <summary>
	        /// 是否放入回收站
	        /// </summary>
	        [XmlElement("is_recycled")]
	        public bool IsRecycled { get; set; }
	
	        /// <summary>
	        /// 更新者id, 传staffId（工号）
	        /// </summary>
	        [XmlElement("modifier_userid")]
	        public string ModifierUserid { get; set; }
	
	        /// <summary>
	        /// 项目名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 父项目id
	        /// </summary>
	        [XmlElement("parent_id")]
	        public string ParentId { get; set; }
	
	        /// <summary>
	        /// 项目ID
	        /// </summary>
	        [XmlElement("project_id")]
	        public string ProjectId { get; set; }
	
	        /// <summary>
	        /// 来源
	        /// </summary>
	        [XmlElement("source")]
	        public string Source { get; set; }
	
	        /// <summary>
	        /// 此字段用于数据迁移的场景，表示任务在源系统中的唯一ID
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 关联的虚拟组织ID
	        /// </summary>
	        [XmlElement("virtual_ding_orgid")]
	        public string VirtualDingOrgid { get; set; }
	
	        /// <summary>
	        /// 项目可见性
	        /// </summary>
	        [XmlElement("visibility")]
	        public string Visibility { get; set; }
}

    }
}
