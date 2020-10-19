using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessProcvisibleGetResponse.
    /// </summary>
    public class OapiProcessProcvisibleGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 失败ErrorCode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 可见列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

        /// <summary>
        /// 成功失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 部门名称或人员名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否启用，0启用，1不启用
	        /// </summary>
	        [XmlElement("unactive_flag")]
	        public long UnactiveFlag { get; set; }
	
	        /// <summary>
	        /// 可见类型：0：部门可见，1 ：人员可见
	        /// </summary>
	        [XmlElement("visible_type")]
	        public long VisibleType { get; set; }
	
	        /// <summary>
	        /// 可见性值，部门id或员工id
	        /// </summary>
	        [XmlElement("visible_value")]
	        public string VisibleValue { get; set; }
}

    }
}
