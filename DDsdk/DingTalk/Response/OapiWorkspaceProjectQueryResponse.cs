using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceProjectQueryResponse.
    /// </summary>
    public class OapiWorkspaceProjectQueryResponse : DingTalkResponse
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
        /// 项目参数返回值
        /// </summary>
        [XmlElement("result")]
        public OpenProjectDtoDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenTagDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenTagDtoDomain : TopObject
{
	        /// <summary>
	        /// 角色的code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 角色的名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenProjectMemberDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenProjectMemberDtoDomain : TopObject
{
	        /// <summary>
	        /// 组织id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 成员名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("open_tag_dto")]
	        public List<OpenTagDtoDomain> Tags { get; set; }
	
	        /// <summary>
	        /// 成员id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenProjectDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenProjectDtoDomain : TopObject
{
	        /// <summary>
	        /// 组织id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 只在创建组织时返回
	        /// </summary>
	        [XmlElement("corp_secret")]
	        public string CorpSecret { get; set; }
	
	        /// <summary>
	        /// 项目创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public long CreateTime { get; set; }
	
	        /// <summary>
	        /// 项目创建人
	        /// </summary>
	        [XmlElement("creator")]
	        public OpenProjectMemberDtoDomain Creator { get; set; }
	
	        /// <summary>
	        /// 组织描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 图标
	        /// </summary>
	        [XmlElement("logo")]
	        public string Logo { get; set; }
	
	        /// <summary>
	        /// 组织名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 支持传入外部业务id做系统关联
	        /// </summary>
	        [XmlElement("outer_id")]
	        public string OuterId { get; set; }
	
	        /// <summary>
	        /// 项目负责人，刚创建时负责人就是创建人
	        /// </summary>
	        [XmlElement("owner")]
	        public OpenProjectMemberDtoDomain Owner { get; set; }
	
	        /// <summary>
	        /// 1项目 2圈子
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

    }
}
