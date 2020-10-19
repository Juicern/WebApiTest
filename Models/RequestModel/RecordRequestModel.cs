using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Models.RequestModel
{
    // 考勤请求模型
    public class RecordRequestModel
    {
        /// <summary>
        /// 企业内的员工id列表，最多不能超过50个
        /// </summary>
        public List<string> userIds { get; set; }
        /// <summary>
        ///查询考勤打卡记录的起始工作日。格式为“yyyy-MM-dd hh:mm:ss”。
        /// </summary>
        public string checkDateFrom { get; set; }
        /// <summary>
        /// 查询考勤打卡记录的结束工作日。格式为“yyyy-MM-dd hh:mm:ss”。注意，起始与结束工作日最多相隔7天
        /// </summary>
        public string checkDateTo { get; set; }
        /// <summary>
        /// 取值为true和false，表示是否为海外企业使用，默认为false。其中，true：海外平台使用，false：国内平台使用
        /// </summary>
        public bool isI18n { get; set; }
    }
}