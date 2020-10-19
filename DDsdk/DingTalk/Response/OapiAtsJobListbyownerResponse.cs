using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsJobListbyownerResponse.
    /// </summary>
    public class OapiAtsJobListbyownerResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 职位数据列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("job_simple_vo")]
        public List<JobSimpleVoDomain> Result { get; set; }

	/// <summary>
/// JobAddressVoDomain Data Structure.
/// </summary>
[Serializable]

public class JobAddressVoDomain : TopObject
{
	        /// <summary>
	        /// 地点详情
	        /// </summary>
	        [XmlElement("detail")]
	        public string Detail { get; set; }
	
	        /// <summary>
	        /// 经度
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 纬度
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 地点名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// JobSimpleVoDomain Data Structure.
/// </summary>
[Serializable]

public class JobSimpleVoDomain : TopObject
{
	        /// <summary>
	        /// 职位地址详情
	        /// </summary>
	        [XmlElement("address")]
	        public JobAddressVoDomain Address { get; set; }
	
	        /// <summary>
	        /// true :校招，false：社招
	        /// </summary>
	        [XmlElement("campus")]
	        public bool Campus { get; set; }
	
	        /// <summary>
	        /// 职位分类
	        /// </summary>
	        [XmlElement("category")]
	        public string Category { get; set; }
	
	        /// <summary>
	        /// 职位地址 市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 职位描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 职位地址 区/县
	        /// </summary>
	        [XmlElement("district")]
	        public string District { get; set; }
	
	        /// <summary>
	        /// 招募人数
	        /// </summary>
	        [XmlElement("head_count")]
	        public long HeadCount { get; set; }
	
	        /// <summary>
	        /// 职位编码
	        /// </summary>
	        [XmlElement("job_code")]
	        public string JobCode { get; set; }
	
	        /// <summary>
	        /// 职位唯一标识
	        /// </summary>
	        [XmlElement("job_id")]
	        public string JobId { get; set; }
	
	        /// <summary>
	        /// 职位类型：FULL-TIME:全职，PART-TIME:兼职，INTERNSHIP:实习，OTHER:其他
	        /// </summary>
	        [XmlElement("job_nature")]
	        public string JobNature { get; set; }
	
	        /// <summary>
	        /// 职位部门id
	        /// </summary>
	        [XmlElement("main_dept_id")]
	        public long MainDeptId { get; set; }
	
	        /// <summary>
	        /// 最高工作年限
	        /// </summary>
	        [XmlElement("max_job_experience")]
	        public long MaxJobExperience { get; set; }
	
	        /// <summary>
	        /// 最高薪水，单位元
	        /// </summary>
	        [XmlElement("max_salary")]
	        public long MaxSalary { get; set; }
	
	        /// <summary>
	        /// 最低工作年限
	        /// </summary>
	        [XmlElement("min_job_experience")]
	        public long MinJobExperience { get; set; }
	
	        /// <summary>
	        /// 最低薪水，单位元
	        /// </summary>
	        [XmlElement("min_salary")]
	        public long MinSalary { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 职位地址 省
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 最低职位要求 1小学 2初中 3高中 4中专 5大专 6本科 7硕士 8 博士 9其他
	        /// </summary>
	        [XmlElement("required_edu")]
	        public long RequiredEdu { get; set; }
	
	        /// <summary>
	        /// 薪资月数
	        /// </summary>
	        [XmlElement("salary_month")]
	        public long SalaryMonth { get; set; }
	
	        /// <summary>
	        /// 是否薪资面议
	        /// </summary>
	        [XmlElement("salary_negotiable")]
	        public bool SalaryNegotiable { get; set; }
	
	        /// <summary>
	        /// 薪资类型，HOUR:小时，DAY:天，WEEK:周，MONTH:月，BY_TIME:次
	        /// </summary>
	        [XmlElement("salary_period")]
	        public string SalaryPeriod { get; set; }
	
	        /// <summary>
	        /// 职位标签
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("string")]
	        public List<string> Tags { get; set; }
}

    }
}
