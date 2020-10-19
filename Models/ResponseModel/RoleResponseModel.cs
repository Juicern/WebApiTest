using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Models.ResponseModel
{
    // 角色请求返回模型
    public class RoleResponseModel
    {
    }

    public class SimpleRole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
    }
}