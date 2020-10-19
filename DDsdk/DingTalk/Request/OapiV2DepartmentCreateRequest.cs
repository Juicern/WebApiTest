using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.department.create
    /// </summary>
    public class OapiV2DepartmentCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2DepartmentCreateResponse>
    {
        /// <summary>
        /// 是否创建一个关联此部门的企业群，默认为false
        /// </summary>
        public Nullable<bool> CreateDeptGroup { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效。总数不能超过200。
        /// </summary>
        public string DeptPermits { get; set; }

        /// <summary>
        /// 扩展字段，JSON格式
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 是否隐藏部门， true表示隐藏 false表示显示
        /// </summary>
        public Nullable<bool> HideDept { get; set; }

        /// <summary>
        /// 部门名称，长度限制为1~64个字符，不允许包含字符‘-’‘，’以及‘,’
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 在父部门中的排序值，order值小的排序靠前
        /// </summary>
        public Nullable<long> Order { get; set; }

        /// <summary>
        /// 限制本部门成员查看通讯录，限制开启后，本部门成员只能看到限定范围内的通讯录。true表示限制开启
        /// </summary>
        public Nullable<bool> OuterDept { get; set; }

        /// <summary>
        /// 是否只能看到所在部门及下级部门通讯录
        /// </summary>
        public Nullable<bool> OuterDeptOnlySelf { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见部门，departmentId列表，总数不能超过200。
        /// </summary>
        public string OuterPermitDepts { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见人员，userid列表，总数不能超过200。
        /// </summary>
        public string OuterPermitUsers { get; set; }

        /// <summary>
        /// 父部门id，根部门id为1
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        /// <summary>
        /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射
        /// </summary>
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，总数不能超过200。
        /// </summary>
        public string UserPermits { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.department.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("create_dept_group", this.CreateDeptGroup);
            parameters.Add("dept_permits", this.DeptPermits);
            parameters.Add("extension", this.Extension);
            parameters.Add("hide_dept", this.HideDept);
            parameters.Add("name", this.Name);
            parameters.Add("order", this.Order);
            parameters.Add("outer_dept", this.OuterDept);
            parameters.Add("outer_dept_only_self", this.OuterDeptOnlySelf);
            parameters.Add("outer_permit_depts", this.OuterPermitDepts);
            parameters.Add("outer_permit_users", this.OuterPermitUsers);
            parameters.Add("parent_id", this.ParentId);
            parameters.Add("source_identifier", this.SourceIdentifier);
            parameters.Add("user_permits", this.UserPermits);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("dept_permits", this.DeptPermits, 200);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 64);
            RequestValidator.ValidateMaxListSize("outer_permit_depts", this.OuterPermitDepts, 200);
            RequestValidator.ValidateMaxListSize("outer_permit_users", this.OuterPermitUsers, 200);
            RequestValidator.ValidateRequired("parent_id", this.ParentId);
            RequestValidator.ValidateMaxListSize("user_permits", this.UserPermits, 200);
        }

        #endregion
    }
}
