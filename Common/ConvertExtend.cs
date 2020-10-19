using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Common
{
    /// <summary>
    /// ���������������ת���ģ��������ص����ڸ�ʽ������ long ����������Ҫ�õ����� yyyy-mm-dd ���ָ�ʽ����Ҫ����ת��
    /// </summary>
    public static class ConvertExtend
    {
        /// <summary>
        /// datetimeתlong
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
        /// longתdatetime
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