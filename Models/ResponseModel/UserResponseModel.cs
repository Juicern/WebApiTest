using WebApiTest.Common;
using System;
using System.Collections.Generic;

namespace WebApiTest.Models.ResponseModel
{
    public class SimpleUserEResponseModel : BaseResponseModel
    {
        public bool HasMore { get; set; }
        public List<SimpleUser> UserList { get; set; }
    }
    public class UserIDListResponseModel : BaseResponseModel
    {
        public List<string> UserIds { get; set; }
    }
    public class SimpleUser
    {
        public string Name { get; set; }
        public string UserID { get; set; }
    }


    public class UserResponseModel : BaseResponseModel
    {
        /// <summary>
        /// 员工在当前企业内的唯一标识，也称staffId。可由企业在创建时指定，并代表一定含义比如工号，创建后不可修改
        /// </summary>
        public string Userid { get; set; }
        /// <summary>
        /// 员工在当前开发者企业账号范围内的唯一标识，系统生成，固定值，不会改变
        /// </summary>
        public string Unionid { get; set; }
        /// <summary>
        /// 员工名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 分机号（仅限企业内部开发调用）
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 办公地点
        /// </summary>
        public string WorkPlace { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 员工的电子邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 员工的企业邮箱，如果员工已经开通了企业邮箱，接口会返回，否则不会返回
        /// </summary>
        public string OrgEmail { get; set; }
        /// <summary>
        /// 是否已经激活，true表示已激活，false表示未激活
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// 在对应的部门中的排序，Map结构的json字符串，key是部门的id，value是人员在这个部门的排序值
        /// </summary>
        public string OrderInDepts { get; set; }
        /// <summary>
        /// 是否为企业的管理员，true表示是，false表示不是
        /// </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// 是否为企业的老板，true表示是，false表示不是
        /// </summary>
        public bool IsBoss { get; set; }
        /// <summary>
        /// 在对应的部门中是否为主管：Map结构的json字符串，key是部门的id，value是人员在这个部门中是否为主管，true表示是，false表示不是
        /// </summary>
        public string IsLeaderInDepts { get; set; }
        /// <summary>
        /// 是否号码隐藏，true表示隐藏，false表示不隐藏
        /// </summary>
        public bool IsHide { get; set; }
        /// <summary>
        /// 成员所属部门id列表
        /// </summary>
        public int[] Department { get; set; }
        /// <summary>
        /// 职位信息
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// 头像url
        /// </summary>
        public string Avatar { get; set; }
        private long _hiredDate;

        /// <summary>
        /// 入职时间。Unix时间戳 （在OA后台通讯录中的员工基础信息中维护过入职时间才会返回)
        /// </summary>
        public long HiredDate
        {
            get
            {
                return _hiredDate;

            }
            set
            {
                HiredDate_Dt = value.ToDateTime();
                _hiredDate = value;
            }

        }
        /// <summary>
        /// 入职时间。Unix时间戳 （在OA后台通讯录中的员工基础信息中维护过入职时间才会返回)(datetime)
        /// </summary>
        public DateTime? HiredDate_Dt { get; set; }
        /// <summary>
        /// 员工工号
        /// </summary>
        public string Jobnumber { get; set; }
        /// <summary>
        /// 扩展属性，可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。
        /// 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址] (http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
        /// </summary>
        //public string Extattr { get; set; }
        /// <summary>
        /// 是否是高管
        /// </summary>
        public bool IsSenior { get; set; }
        /// <summary>
        /// 国家地区码
        /// </summary>
        public string StateCode { get; set; }

        public List<SimpleRole> Roles { get; set; }
    }

    public class UserIDResponseModel : BaseResponseModel
    {
        public string UserID { get; set; }
    }
}