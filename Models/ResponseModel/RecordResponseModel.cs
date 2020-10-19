using WebApiTest.Common;
// using WebApiTest.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Models.ResponseModel
{
    // 考勤请求返回模型
    public class RecordResponseModel : BaseResponseModel
    {
        public List<SimpleRecord> RecordResult { get; set; }
    }
    public class SimpleRecord
    {
        public long ID { get; set; }
        /// <summary>
        /// 唯一标识ID
        /// </summary>
        public long GroupID { get; set; }
        /// <summary>
        /// 考勤组ID
        /// </summary>
        public long PlanID { get; set; }
        private long _workDate { get; set; }
        /// <summary>
        /// 工作日
        /// </summary>
        public long WorkDate
        {
            get
            {
                return _workDate;

            }
            set
            {
                WorkDate_Dt = value.ToDateTime();
                _workDate = value;
            }

        }
        /// <summary>
        /// 工作日(datetime)
        /// </summary>
        public DateTime? WorkDate_Dt { get; set; }
        /// <summary>
        /// 企业ID
        /// </summary>
        public string CorpID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// 考勤类型，
        ///OnDuty：上班
        ///OffDuty：下班
        /// </summary>
        public string CheckType { get; set; }
        /// <summary>
        /// 考勤组ID
        /// </summary>
        public string SourceType { get; set; }
        /// <summary>
        /// 时间结果
        /// </summary>
        public string TimeResult { get; set; }
        /// <summary>
        /// 位置结果
        /// </summary>
        public string LocationResult { get; set; }
        /// <summary>
        /// 关联的审批id，当该字段非空时，表示打卡记录与请假、加班等审批有关
        /// </summary>
        public string ApproveID { get; set; }
        /// <summary>
        /// 关联的审批实例id，当该字段非空时，表示打卡记录与请假、加班等审批有关。可以与获取单个审批数据配合使用
        /// </summary>
        public string ProcInstID { get; set; }

        private long _baseCheckTime;
        /// <summary>
        /// 计算迟到和早退，基准时间；也可作为排班打卡时间
        /// </summary>
        public long BaseCheckTime
        {
            get
            {
                return _baseCheckTime;

            }
            set
            {
                BaseCheckTime_Dt = value.ToDateTime();
                _baseCheckTime = value;
            }

        }
        /// <summary>
        /// 计算迟到和早退，基准时间；也可作为排班打卡时间(datetime)
        /// </summary>
        public DateTime? BaseCheckTime_Dt { get; set; }

        private long _userCheckTime;
        /// <summary>
        /// 实际打卡时间
        /// </summary>
        public long UserCheckTime
        {
            get
            {
                return _userCheckTime;

            }
            set
            {
                UserCheckTime_Dt = value.ToDateTime();
                _userCheckTime = value;
            }

        }
        /// <summary>
        /// 实际打卡时间
        /// </summary>
        public DateTime? UserCheckTime_Dt { get; set; }
        /// <summary>
        /// 考勤班次id，没有的话表示该次打卡不在排班内
        /// </summary>
        public string ClassID { get; set; }
        /// <summary>
        /// 是否合法，当timeResult和locationResult都为Normal时，该值为Y；否则为N
        /// </summary>
        public string IsLegal { get; set; }
        /// <summary>
        /// 定位方法
        /// </summary>
        public string LocationMethod { get; set; }
        /// <summary>
        /// 设备id
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// 用户打卡地址
        /// </summary>
        public string UserAddress { get; set; }
        /// <summary>
        /// 用户打卡经度
        /// </summary>
        public decimal UserLongitude { get; set; }
        /// <summary>
        /// 用户打卡纬度
        /// </summary>
        public decimal UserLatitude { get; set; }
        /// <summary>
        /// 用户打卡定位精度
        /// </summary>
        public decimal UserAccuracy { get; set; }
        /// <summary>
        /// 用户打卡wifi SSID
        /// </summary>
        public string UserSsid { get; set; }
        /// <summary>
        /// 用户打卡wifi Mac地址
        /// </summary>
        public string UserMacAddr { get; set; }

        private long _planCheckTime;
        /// <summary>
        /// 排班打卡时间
        /// </summary>
        public long PlanCheckTime
        {
            get
            {
                return _planCheckTime;

            }
            set
            {
                PlanCheckTime_Dt = value.ToDateTime();
                _planCheckTime = value;
            }

        }
        /// <summary>
        /// 排班打卡时间
        /// </summary>
        public DateTime? PlanCheckTime_Dt { get; set; }
        /// <summary>
        /// 基准地址
        /// </summary>
        public string BaseAddress { get; set; }
        /// <summary>
        /// 基准经度
        /// </summary>
        public decimal BaseLongitude { get; set; }
        /// <summary>
        /// 基准纬度
        /// </summary>
        public decimal BaseLatitude { get; set; }
        /// <summary>
        /// 基准定位精度
        /// </summary>
        public decimal BaseAccuracy { get; set; }
        /// <summary>
        /// 基准wifi ssid
        /// </summary>
        public string BaseSsid { get; set; }
        /// <summary>
        /// 基准 Mac 地址
        /// </summary>
        public string BaseMacAddr { get; set; }
        /// <summary>
        /// 打卡备注
        /// </summary>
        public string OutsideRemark { get; set; }
    }
}