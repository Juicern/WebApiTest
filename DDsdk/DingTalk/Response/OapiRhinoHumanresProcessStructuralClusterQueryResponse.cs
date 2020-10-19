using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoHumanresProcessStructuralClusterQueryResponse.
    /// </summary>
    public class OapiRhinoHumanresProcessStructuralClusterQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("external_msg_info")]
        public string ExternalMsgInfo { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [XmlElement("hsfcode")]
        public long Hsfcode { get; set; }

        /// <summary>
        /// 结构化工序关联dto
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("model")]
        public List<ModelDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ProcessStructuralClusterDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessStructuralClusterDtoDomain : TopObject
{
	        /// <summary>
	        /// 辅料
	        /// </summary>
	        [XmlElement("accessory")]
	        public string Accessory { get; set; }
	
	        /// <summary>
	        /// 动作
	        /// </summary>
	        [XmlElement("action")]
	        public string Action { get; set; }
	
	        /// <summary>
	        /// 主键
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 部件
	        /// </summary>
	        [XmlElement("part")]
	        public string Part { get; set; }
	
	        /// <summary>
	        /// 部位
	        /// </summary>
	        [XmlElement("position")]
	        public string Position { get; set; }
	
	        /// <summary>
	        /// 线迹
	        /// </summary>
	        [XmlElement("stitch")]
	        public string Stitch { get; set; }
}

	/// <summary>
/// ModelDomain Data Structure.
/// </summary>
[Serializable]

public class ModelDomain : TopObject
{
	        /// <summary>
	        /// 工序id
	        /// </summary>
	        [XmlElement("biz_id_process")]
	        public string BizIdProcess { get; set; }
	
	        /// <summary>
	        /// 结构化工序详情
	        /// </summary>
	        [XmlElement("process_structural_cluster")]
	        public ProcessStructuralClusterDtoDomain ProcessStructuralCluster { get; set; }
}

    }
}
