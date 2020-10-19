using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmAuthGroupPermissionListResponse.
    /// </summary>
    public class OapiCrmAuthGroupPermissionListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误内容
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// OperateScopeDomain Data Structure.
/// </summary>
[Serializable]

public class OperateScopeDomain : TopObject
{
	        /// <summary>
	        /// 是否有权限
	        /// </summary>
	        [XmlElement("has_auth")]
	        public bool HasAuth { get; set; }
	
	        /// <summary>
	        /// 操作名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 操作类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// DeptInfoDomain Data Structure.
/// </summary>
[Serializable]

public class DeptInfoDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
}

	/// <summary>
/// StaffInfoDomain Data Structure.
/// </summary>
[Serializable]

public class StaffInfoDomain : TopObject
{
	        /// <summary>
	        /// 员工名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("staff_id")]
	        public string StaffId { get; set; }
}

	/// <summary>
/// ExtDomain Data Structure.
/// </summary>
[Serializable]

public class ExtDomain : TopObject
{
	        /// <summary>
	        /// 管理部门信息
	        /// </summary>
	        [XmlArray("dept_info")]
	        [XmlArrayItem("dept_info")]
	        public List<DeptInfoDomain> DeptInfo { get; set; }
	
	        /// <summary>
	        /// 员工信息
	        /// </summary>
	        [XmlArray("staff_info")]
	        [XmlArrayItem("staff_info")]
	        public List<StaffInfoDomain> StaffInfo { get; set; }
}

	/// <summary>
/// ManageScopeDomain Data Structure.
/// </summary>
[Serializable]

public class ManageScopeDomain : TopObject
{
	        /// <summary>
	        /// 扩展内容
	        /// </summary>
	        [XmlElement("ext")]
	        public ExtDomain Ext { get; set; }
	
	        /// <summary>
	        /// 是否有权限
	        /// </summary>
	        [XmlElement("has_auth")]
	        public bool HasAuth { get; set; }
	
	        /// <summary>
	        /// 管理范围名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 管理范围类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// AuthObjectsDomain Data Structure.
/// </summary>
[Serializable]

public class AuthObjectsDomain : TopObject
{
	        /// <summary>
	        /// 表单名称
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 管理范围
	        /// </summary>
	        [XmlArray("manage_scope")]
	        [XmlArrayItem("manage_scope")]
	        public List<ManageScopeDomain> ManageScope { get; set; }
	
	        /// <summary>
	        /// 权限组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 操作范围
	        /// </summary>
	        [XmlArray("operate_scope")]
	        [XmlArrayItem("operate_scope")]
	        public List<OperateScopeDomain> OperateScope { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 权限内容
	        /// </summary>
	        [XmlArray("auth_objects")]
	        [XmlArrayItem("auth_objects")]
	        public List<AuthObjectsDomain> AuthObjects { get; set; }
	
	        /// <summary>
	        /// 权限组id
	        /// </summary>
	        [XmlElement("role_id")]
	        public long RoleId { get; set; }
}

    }
}
