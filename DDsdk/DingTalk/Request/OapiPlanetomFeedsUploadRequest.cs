using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.planetom.feeds.upload
    /// </summary>
    public class OapiPlanetomFeedsUploadRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPlanetomFeedsUploadResponse>
    {
        /// <summary>
        /// 内容对应的应用ID
        /// </summary>
        public Nullable<long> FeedAppId { get; set; }

        /// <summary>
        /// 课程列表
        /// </summary>
        public string FeedInfoModels { get; set; }

        public List<BatchUploadFeedInfoModelDomain> FeedInfoModels_ { set { this.FeedInfoModels = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 提交人的手机号码
        /// </summary>
        public string UserPhone { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.planetom.feeds.upload";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("feed_app_id", this.FeedAppId);
            parameters.Add("feed_info_models", this.FeedInfoModels);
            parameters.Add("user_phone", this.UserPhone);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("feed_app_id", this.FeedAppId);
            RequestValidator.ValidateRequired("feed_info_models", this.FeedInfoModels);
            RequestValidator.ValidateObjectMaxListSize("feed_info_models", this.FeedInfoModels, 20);
            RequestValidator.ValidateRequired("user_phone", this.UserPhone);
        }

	/// <summary>
/// FeedContentModelDomain Data Structure.
/// </summary>
[Serializable]

public class FeedContentModelDomain : TopObject
{
	        /// <summary>
	        /// 内容类型 2 视频 3 音频
	        /// </summary>
	        [XmlElement("feed_type")]
	        public Nullable<long> FeedType { get; set; }
	
	        /// <summary>
	        /// 内容标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 视频下载地址
	        /// </summary>
	        [XmlElement("video_url")]
	        public string VideoUrl { get; set; }
}

	/// <summary>
/// FeedBaseModelDomain Data Structure.
/// </summary>
[Serializable]

public class FeedBaseModelDomain : TopObject
{
	        /// <summary>
	        /// 课程封面URL
	        /// </summary>
	        [XmlElement("cover_url")]
	        public string CoverUrl { get; set; }
	
	        /// <summary>
	        /// 课程自定义标签
	        /// </summary>
	        [XmlElement("cust_tag")]
	        public string CustTag { get; set; }
	
	        /// <summary>
	        /// 课程简介
	        /// </summary>
	        [XmlElement("introduction")]
	        public string Introduction { get; set; }
	
	        /// <summary>
	        /// 课程图片简介
	        /// </summary>
	        [XmlElement("pic_introduction")]
	        public string PicIntroduction { get; set; }
	
	        /// <summary>
	        /// 课程标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// FeedPayModelDomain Data Structure.
/// </summary>
[Serializable]

public class FeedPayModelDomain : TopObject
{
	        /// <summary>
	        /// 客服手机号码
	        /// </summary>
	        [XmlElement("cs_phone")]
	        public string CsPhone { get; set; }
	
	        /// <summary>
	        /// 优惠结束时间
	        /// </summary>
	        [XmlElement("dis_end_time")]
	        public Nullable<long> DisEndTime { get; set; }
	
	        /// <summary>
	        /// 优惠后价格 单位分
	        /// </summary>
	        [XmlElement("dis_price")]
	        public Nullable<long> DisPrice { get; set; }
	
	        /// <summary>
	        /// 优惠开始时间
	        /// </summary>
	        [XmlElement("dis_start_time")]
	        public Nullable<long> DisStartTime { get; set; }
	
	        /// <summary>
	        /// 售卖份数
	        /// </summary>
	        [XmlElement("limit_count")]
	        public Nullable<long> LimitCount { get; set; }
	
	        /// <summary>
	        /// 是否付费
	        /// </summary>
	        [XmlElement("need_pay")]
	        public Nullable<bool> NeedPay { get; set; }
	
	        /// <summary>
	        /// 是否优惠
	        /// </summary>
	        [XmlElement("preferential")]
	        public Nullable<bool> Preferential { get; set; }
	
	        /// <summary>
	        /// 价格 单位分
	        /// </summary>
	        [XmlElement("price")]
	        public Nullable<long> Price { get; set; }
}

	/// <summary>
/// BatchUploadFeedInfoModelDomain Data Structure.
/// </summary>
[Serializable]

public class BatchUploadFeedInfoModelDomain : TopObject
{
	        /// <summary>
	        /// 课程基础
	        /// </summary>
	        [XmlElement("base_model")]
	        public FeedBaseModelDomain BaseModel { get; set; }
	
	        /// <summary>
	        /// 内容列表，一个为单课，多个为系列课
	        /// </summary>
	        [XmlArray("content_models")]
	        [XmlArrayItem("feed_content_model")]
	        public List<FeedContentModelDomain> ContentModels { get; set; }
	
	        /// <summary>
	        /// 支付信息
	        /// </summary>
	        [XmlElement("pay_model")]
	        public FeedPayModelDomain PayModel { get; set; }
	
	        /// <summary>
	        /// 资源类型 0 免费公开课 4 平价引流课 5 专栏课 6 训练营课
	        /// </summary>
	        [XmlElement("resource_type")]
	        public Nullable<long> ResourceType { get; set; }
	
	        /// <summary>
	        /// 服务群名称
	        /// </summary>
	        [XmlElement("work_group_name")]
	        public string WorkGroupName { get; set; }
}

        #endregion
    }
}
