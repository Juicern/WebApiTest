using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Models.ResponseModel
{
    // 父类请求返回模型
    public class BaseResponseModel
    {
        public int Errcode { get; set; }
        public string Errmsg { get; set; }
    }
}