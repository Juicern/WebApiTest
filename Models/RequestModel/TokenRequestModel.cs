using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Models.ResponseModel
{
    // Token请求返回模型
    public class TokenResponseModel : BaseResponseModel
    {
        public string Access_Token { get; set; }
        public int Expires_in { get; set; }
    }
}