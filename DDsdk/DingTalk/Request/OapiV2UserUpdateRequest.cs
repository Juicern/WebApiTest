using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.user.update
    /// </summary>
    public class OapiV2UserUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2UserUpdateResponse>
    {
        /// <summary>
        /// 所属部门id列表
        /// </summary>
        public string DeptIdList { get; set; }

        /// <summary>
        /// 员工在对应的部门中的排序。
        /// </summary>
        public string DeptOrderList { get; set; }

        public List<DeptOrderDomain> DeptOrderList_ { set { this.DeptOrderList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 员工在对应的部门中的职位。
        /// </summary>
        public string DeptTitleList { get; set; }

        public List<DeptTitleDomain> DeptTitleList_ { set { this.DeptTitleList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 员工邮箱，长度最大64个字符。企业内必须唯一，不可重复。
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 是否号码隐藏。隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉免费商务电话。
        /// </summary>
        public Nullable<bool> HideMobile { get; set; }

        /// <summary>
        /// 入职时间，Unix时间戳，单位ms。
        /// </summary>
        public Nullable<long> HiredDate { get; set; }

        /// <summary>
        /// 员工工号，长度最大64个字符。
        /// </summary>
        public string JobNumber { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 手机号码，企业内必须唯一，不可重复。如果是国际号码，请使用+xx-xxxxxx的格式
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 员工名称，长度最大64个字符。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 员工的企业邮箱，员工的企业邮箱已开通，才能增加此字段。
        /// </summary>
        public string OrgEmail { get; set; }

        /// <summary>
        /// 备注，长度最大1024个字符。
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 是否高管模式。开启后，手机号码对所有员工隐藏。普通员工无法对其发DING、发起钉钉免费商务电话。高管之间不受影响。
        /// </summary>
        public Nullable<bool> SeniorMode { get; set; }

        /// <summary>
        /// 分机号，长度最大50个字符。企业内必须唯一，不可重复
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 职位，长度最大300个字符。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 员工id，长度最大64个字符。员工在当前企业内的唯一标识。如果不传，服务器将自动生成一个userid。创建后不可修改，企业内必须唯一。
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 办公地点，长度最大50个字符。
        /// </summary>
        public string WorkPlace { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.user.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_id_list", this.DeptIdList);
            parameters.Add("dept_order_list", this.DeptOrderList);
            parameters.Add("dept_title_list", this.DeptTitleList);
            parameters.Add("email", this.Email);
            parameters.Add("extension", this.Extension);
            parameters.Add("hide_mobile", this.HideMobile);
            parameters.Add("hired_date", this.HiredDate);
            parameters.Add("job_number", this.JobNumber);
            parameters.Add("language", this.Language);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("name", this.Name);
            parameters.Add("org_email", this.OrgEmail);
            parameters.Add("remark", this.Remark);
            parameters.Add("senior_mode", this.SeniorMode);
            parameters.Add("telephone", this.Telephone);
            parameters.Add("title", this.Title);
            parameters.Add("userid", this.Userid);
            parameters.Add("work_place", this.WorkPlace);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("dept_id_list", this.DeptIdList, 100);
            RequestValidator.ValidateObjectMaxListSize("dept_order_list", this.DeptOrderList, 100);
            RequestValidator.ValidateObjectMaxListSize("dept_title_list", this.DeptTitleList, 100);
            RequestValidator.ValidateMaxLength("email", this.Email, 64);
            RequestValidator.ValidateMaxLength("extension", this.Extension, 2000);
            RequestValidator.ValidateMinValue("hired_date", this.HiredDate, 1);
            RequestValidator.ValidateMaxLength("job_number", this.JobNumber, 64);
            RequestValidator.ValidateMaxLength("language", this.Language, 6);
            RequestValidator.ValidateMaxLength("name", this.Name, 64);
            RequestValidator.ValidateMaxLength("remark", this.Remark, 1024);
            RequestValidator.ValidateMaxLength("telephone", this.Telephone, 50);
            RequestValidator.ValidateMaxLength("title", this.Title, 300);
            RequestValidator.ValidateRequired("userid", this.Userid);
            RequestValidator.ValidateMaxLength("userid", this.Userid, 64);
            RequestValidator.ValidateMaxLength("work_place", this.WorkPlace, 50);
        }

	/// <summary>
/// DeptOrderDomain Data Structure.
/// </summary>
[Serializable]

public class DeptOrderDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public Nullable<long> DeptId { get; set; }
	
	        /// <summary>
	        /// 员工在部门中的排序。
	        /// </summary>
	        [XmlElement("order")]
	        public Nullable<long> Order { get; set; }
}

	/// <summary>
/// DeptTitleDomain Data Structure.
/// </summary>
[Serializable]

public class DeptTitleDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public Nullable<long> DeptId { get; set; }
	
	        /// <summary>
	        /// 员工在部门中的职位。
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
