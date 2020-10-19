using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmAuthGroupMemberListResponse.
    /// </summary>
    public class OapiCrmAuthGroupMemberListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// StaffDomain Data Structure.
/// </summary>
[Serializable]

public class StaffDomain : TopObject
{
	        /// <summary>
	        /// 员工姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// DeptDomain Data Structure.
/// </summary>
[Serializable]

public class DeptDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// TagDomain Data Structure.
/// </summary>
[Serializable]

public class TagDomain : TopObject
{
	        /// <summary>
	        /// 角色名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 角色id
	        /// </summary>
	        [XmlElement("tag_id")]
	        public long TagId { get; set; }
}

	/// <summary>
/// MemberInfoDomain Data Structure.
/// </summary>
[Serializable]

public class MemberInfoDomain : TopObject
{
	        /// <summary>
	        /// 是否是全员分组
	        /// </summary>
	        [XmlElement("all_member")]
	        public bool AllMember { get; set; }
	
	        /// <summary>
	        /// 部门信息
	        /// </summary>
	        [XmlArray("dept")]
	        [XmlArrayItem("dept")]
	        public List<DeptDomain> Dept { get; set; }
	
	        /// <summary>
	        /// 员工信息
	        /// </summary>
	        [XmlArray("staff")]
	        [XmlArrayItem("staff")]
	        public List<StaffDomain> Staff { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlArray("tag")]
	        [XmlArrayItem("tag")]
	        public List<TagDomain> Tag { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 成员信息
	        /// </summary>
	        [XmlElement("member_info")]
	        public MemberInfoDomain MemberInfo { get; set; }
	
	        /// <summary>
	        /// 权限组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 权限组id
	        /// </summary>
	        [XmlElement("role_id")]
	        public long RoleId { get; set; }
}

    }
}
