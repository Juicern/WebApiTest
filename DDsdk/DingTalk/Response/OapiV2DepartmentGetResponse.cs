using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2DepartmentGetResponse.
    /// </summary>
    public class OapiV2DepartmentGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 部门详情
        /// </summary>
        [XmlElement("result")]
        public DeptGetResponseDomain Result { get; set; }

	/// <summary>
/// DeptGetResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptGetResponseDomain : TopObject
{
	        /// <summary>
	        /// 当群已经创建后，是否有新人加入部门会自动加入该群
	        /// </summary>
	        [XmlElement("auto_add_user")]
	        public bool AutoAddUser { get; set; }
	
	        /// <summary>
	        /// 是否同步创建一个关联此部门的企业群, true表示是, false表示不是
	        /// </summary>
	        [XmlElement("create_dept_group")]
	        public bool CreateDeptGroup { get; set; }
	
	        /// <summary>
	        /// 部门群ID
	        /// </summary>
	        [XmlElement("dept_group_chat_id")]
	        public string DeptGroupChatId { get; set; }
	
	        /// <summary>
	        /// 部门ID
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门的主管列表
	        /// </summary>
	        [XmlArray("dept_manager_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> DeptManagerUseridList { get; set; }
	
	        /// <summary>
	        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的数组
	        /// </summary>
	        [XmlArray("dept_permits")]
	        [XmlArrayItem("number")]
	        public List<long> DeptPermits { get; set; }
	
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("extention")]
	        public string Extention { get; set; }
	
	        /// <summary>
	        /// 部门是否来自关联组织
	        /// </summary>
	        [XmlElement("from_union_org")]
	        public bool FromUnionOrg { get; set; }
	
	        /// <summary>
	        /// 部门群是否包含子部门
	        /// </summary>
	        [XmlElement("group_contain_sub_dept")]
	        public bool GroupContainSubDept { get; set; }
	
	        /// <summary>
	        /// 是否隐藏部门, true表示隐藏, false表示显示
	        /// </summary>
	        [XmlElement("hide_dept")]
	        public bool HideDept { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 在父部门中的次序值
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// 企业群群主ID
	        /// </summary>
	        [XmlElement("org_dept_owner")]
	        public string OrgDeptOwner { get; set; }
	
	        /// <summary>
	        /// 是否本部门的员工仅可见员工自己, 为true时，本部门员工默认只能看到员工自己
	        /// </summary>
	        [XmlElement("outer_dept")]
	        public bool OuterDept { get; set; }
	
	        /// <summary>
	        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见部门
	        /// </summary>
	        [XmlArray("outer_permit_depts")]
	        [XmlArrayItem("number")]
	        public List<long> OuterPermitDepts { get; set; }
	
	        /// <summary>
	        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见人员
	        /// </summary>
	        [XmlArray("outer_permit_users")]
	        [XmlArrayItem("string")]
	        public List<string> OuterPermitUsers { get; set; }
	
	        /// <summary>
	        /// 父部门id，根部门为1
	        /// </summary>
	        [XmlElement("parent_id")]
	        public long ParentId { get; set; }
	
	        /// <summary>
	        /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射
	        /// </summary>
	        [XmlElement("source_identifier")]
	        public string SourceIdentifier { get; set; }
	
	        /// <summary>
	        /// 教育行业部门类型，包括campus,period,grade,class.
	        /// </summary>
	        [XmlElement("tags")]
	        public string Tags { get; set; }
	
	        /// <summary>
	        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的数组
	        /// </summary>
	        [XmlArray("user_permits")]
	        [XmlArrayItem("string")]
	        public List<string> UserPermits { get; set; }
}

    }
}
