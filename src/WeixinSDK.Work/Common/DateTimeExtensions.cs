using System;

namespace WeixinSDK.Work.Common
{
    /// <summary>
    /// 日期时间扩展方法
    /// </summary>
    internal static class DateTimeExtensions
    {
        /// <summary>
        /// Unix起始时间
        /// </summary>
        public static DateTime BaseTime = new DateTime(1970, 1, 1);

        /// <summary>
        /// 将c# DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="dateTime">时间（本地时间）</param>
        /// <returns>Unix时间戳（UTC时间）</returns>
        public static int ToUnixTime(this DateTime dateTime)
        {
            return (int) ((dateTime.ToUniversalTime().Ticks - BaseTime.Ticks) / 10000000);
        }

        /// <summary>
        /// 将Unix时间戳格式转换为c# DateTime时间格式
        /// </summary>
        /// <param name="unixTime">Unix时间戳（UTC时间）</param>
        /// <returns>DateTime（本地时间）</returns>
        public static DateTime FromUnixTime(this int unixTime)
        {
            return BaseTime.AddTicks(unixTime * 10000000L).ToLocalTime();
        }
    }
}
