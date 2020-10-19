using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.create
    /// </summary>
    public class OapiEduCourseCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseCreateResponse>
    {
        /// <summary>
        /// 业务唯一键，用于保证课程的唯一性，防止重复创建
        /// </summary>
        public string BizKey { get; set; }

        /// <summary>
        /// 课程的结束时间，Unix毫秒时间戳
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 课程介绍
        /// </summary>
        public string Introduce { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 当前用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 课程的开始时间，Unix毫秒时间戳
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        /// <summary>
        /// 老师的组织CorpId
        /// </summary>
        public string TeacherCorpid { get; set; }

        /// <summary>
        /// 老师的用户ID
        /// </summary>
        public string TeacherUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_key", this.BizKey);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("introduce", this.Introduce);
            parameters.Add("name", this.Name);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("teacher_corpid", this.TeacherCorpid);
            parameters.Add("teacher_userid", this.TeacherUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_key", this.BizKey);
            RequestValidator.ValidateMaxLength("biz_key", this.BizKey, 64);
            RequestValidator.ValidateRequired("introduce", this.Introduce);
            RequestValidator.ValidateMaxLength("introduce", this.Introduce, 120);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 64);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("teacher_corpid", this.TeacherCorpid);
            RequestValidator.ValidateRequired("teacher_userid", this.TeacherUserid);
        }

        #endregion
    }
}
