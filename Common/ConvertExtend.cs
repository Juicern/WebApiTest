using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Common
{
    /// <summary>
    /// 这个类是用于日期转换的，钉钉返回的日期格式类型是 long 类型我们需要拿到的是 yyyy-mm-dd 这种格式的需要进行转换
    /// </summary>
    public static class ConvertExtend
    {
        /// <summary>
        /// datetime转long
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static long ToLong(this DateTime dt)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan toNow = dt.Subtract(dtStart);
            long timeStamp = toNow.Ticks;
            timeStamp = long.Parse(timeStamp.ToString().Substring(0, timeStamp.ToString().Length - 4));
            return timeStamp;
        }


        /// <summary>
        /// long转datetime
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this long d)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(d + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime dtResult = dtStart.Add(toNow);
            return dtResult;
        }
    }
}