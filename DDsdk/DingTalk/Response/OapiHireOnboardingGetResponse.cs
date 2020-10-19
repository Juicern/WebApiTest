using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHireOnboardingGetResponse.
    /// </summary>
    public class OapiHireOnboardingGetResponse : DingTalkResponse
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
        /// 引导结果
        /// </summary>
        [XmlElement("result")]
        public OnboardingVoDomain Result { get; set; }

	/// <summary>
/// FeatureGuideVoDomain Data Structure.
/// </summary>
[Serializable]

public class FeatureGuideVoDomain : TopObject
{
	        /// <summary>
	        /// 功能引导状态
	        /// </summary>
	        [XmlElement("guide_status")]
	        public string GuideStatus { get; set; }
	
	        /// <summary>
	        /// 功能引导创建时间
	        /// </summary>
	        [XmlElement("guide_time")]
	        public long GuideTime { get; set; }
}

	/// <summary>
/// OnboardingVoDomain Data Structure.
/// </summary>
[Serializable]

public class OnboardingVoDomain : TopObject
{
	        /// <summary>
	        /// 人才推荐引导结果
	        /// </summary>
	        [XmlElement("candidate_recommend_guide")]
	        public FeatureGuideVoDomain CandidateRecommendGuide { get; set; }
	
	        /// <summary>
	        /// 新手引导创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public long CreateTime { get; set; }
	
	        /// <summary>
	        /// 职位引导结果
	        /// </summary>
	        [XmlElement("job_guide")]
	        public FeatureGuideVoDomain JobGuide { get; set; }
	
	        /// <summary>
	        /// 简历邮箱设置引导结果
	        /// </summary>
	        [XmlElement("resume_collect_mail_guide")]
	        public FeatureGuideVoDomain ResumeCollectMailGuide { get; set; }
}

    }
}
