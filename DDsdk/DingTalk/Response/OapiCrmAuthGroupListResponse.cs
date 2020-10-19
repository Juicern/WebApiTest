using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmAuthGroupListResponse.
    /// </summary>
    public class OapiCrmAuthGroupListResponse : DingTalkResponse
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
        [XmlArray("result")]
        [XmlArrayItem("role_group_vo")]
        public List<RoleGroupVoDomain> Result { get; set; }

	/// <summary>
/// RoleGroupVoDomain Data Structure.
/// </summary>
[Serializable]

public class RoleGroupVoDomain : TopObject
{
	        /// <summary>
	        /// 角色组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 角色组id
	        /// </summary>
	        [XmlElement("role_id")]
	        public long RoleId { get; set; }
}

    }
}
