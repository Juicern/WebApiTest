using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Models.ResponseModel
{
    // 部门请求返回模型
    public class DepartmentReponseModel : BaseResponseModel
    {
        public List<Department> Department { get; set; }
    }

    public class Department
    {
        public long ID { get; set; }
        public bool AutoAddUser { get; set; }
        public string Name { get; set; }
        public bool CreateDeptGroup { get; set; }
        public string Ext { get; set; }
    }
}