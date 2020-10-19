using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.circle.post.create
    /// </summary>
    public class OapiWorkspaceCirclePostCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCirclePostCreateResponse>
    {
        /// <summary>
        /// 创建动态的入参
        /// </summary>
        public string Req { get; set; }

        public FvPostCreateOpenDtoDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.circle.post.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("req", this.Req);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("req", this.Req);
        }

	/// <summary>
/// FvDingPanFileContentOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvDingPanFileContentOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 文件通过钉盘接口上传后获得的mediaId
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 文件名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// FvAttachmentsOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvAttachmentsOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 钉盘文件列表
	        /// </summary>
	        [XmlArray("ding_files")]
	        [XmlArrayItem("fv_ding_pan_file_content_open_dto")]
	        public List<FvDingPanFileContentOpenDtoDomain> DingFiles { get; set; }
}

	/// <summary>
/// FvPhotoOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvPhotoOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 图片url或通过钉盘接口上传获得的mediaId
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
}

	/// <summary>
/// FvPhotoContentOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvPhotoContentOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 图片内容列表
	        /// </summary>
	        [XmlArray("photos")]
	        [XmlArrayItem("fv_photo_open_dto")]
	        public List<FvPhotoOpenDtoDomain> Photos { get; set; }
}

	/// <summary>
/// FvVideoContentOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvVideoContentOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 视频比特率
	        /// </summary>
	        [XmlElement("bitrate")]
	        public Nullable<long> Bitrate { get; set; }
	
	        /// <summary>
	        /// 视频播放时长，单位秒
	        /// </summary>
	        [XmlElement("duration")]
	        public Nullable<long> Duration { get; set; }
	
	        /// <summary>
	        /// 视频名字
	        /// </summary>
	        [XmlElement("file_name")]
	        public string FileName { get; set; }
	
	        /// <summary>
	        /// 视频文件大小
	        /// </summary>
	        [XmlElement("file_size")]
	        public Nullable<long> FileSize { get; set; }
	
	        /// <summary>
	        /// 视频类型
	        /// </summary>
	        [XmlElement("file_type")]
	        public string FileType { get; set; }
	
	        /// <summary>
	        /// 视频高度
	        /// </summary>
	        [XmlElement("height")]
	        public Nullable<long> Height { get; set; }
	
	        /// <summary>
	        /// 视频封面图url或通过钉盘接口上传获得的mediaId
	        /// </summary>
	        [XmlElement("pic_media_id")]
	        public string PicMediaId { get; set; }
	
	        /// <summary>
	        /// 视频url或通过钉盘接口上传获得的mediaId
	        /// </summary>
	        [XmlElement("video_media_id")]
	        public string VideoMediaId { get; set; }
	
	        /// <summary>
	        /// 视频宽度
	        /// </summary>
	        [XmlElement("width")]
	        public Nullable<long> Width { get; set; }
}

	/// <summary>
/// FvPostContentOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvPostContentOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 附件内容
	        /// </summary>
	        [XmlElement("attachments")]
	        public FvAttachmentsOpenDtoDomain Attachments { get; set; }
	
	        /// <summary>
	        /// 动态类型，1：文本动态；2：图片动态；3：视频动态
	        /// </summary>
	        [XmlElement("content_type")]
	        public Nullable<long> ContentType { get; set; }
	
	        /// <summary>
	        /// 图片内容
	        /// </summary>
	        [XmlElement("photo_content")]
	        public FvPhotoContentOpenDtoDomain PhotoContent { get; set; }
	
	        /// <summary>
	        /// 文本内容
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 视频内容
	        /// </summary>
	        [XmlElement("video_content")]
	        public FvVideoContentOpenDtoDomain VideoContent { get; set; }
}

	/// <summary>
/// FvPostTagOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvPostTagOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 标签名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 标签id
	        /// </summary>
	        [XmlElement("tag_id")]
	        public Nullable<long> TagId { get; set; }
	
	        /// <summary>
	        /// 标签类型，2：话题；9：标签
	        /// </summary>
	        [XmlElement("tag_type")]
	        public Nullable<long> TagType { get; set; }
}

	/// <summary>
/// FvPostCreateOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class FvPostCreateOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 用户在归属组织内的userId
	        /// </summary>
	        [XmlElement("belong_corp_user_id")]
	        public string BelongCorpUserId { get; set; }
	
	        /// <summary>
	        /// 动态的内容
	        /// </summary>
	        [XmlElement("content")]
	        public FvPostContentOpenDtoDomain Content { get; set; }
	
	        /// <summary>
	        /// 圈子的corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 动态所属标签或话题
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("fv_post_tag_open_dto")]
	        public List<FvPostTagOpenDtoDomain> Tags { get; set; }
	
	        /// <summary>
	        /// 请求的唯一标识，防止同一请求多次访问。若重复会返回错误:需要uuid
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
