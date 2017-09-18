using System.Collections.Generic;

namespace WeixinSDK.Work.Common
{
    internal static class ListExtensions
    {
        /// <summary>
        /// 将整数列表转换成分隔符分隔的ID列表字符串返回
        /// </summary>
        /// <param name="this">整数列表</param>
        /// <param name="separator">分隔符，默认【|】</param>
        /// <returns>分隔符分隔的ID列表字符串</returns>
        public static string ToIds(this IList<int> @this, string separator = "|")
        {
            return string.Join("|", @this ?? new List<int>());
        }

        /// <summary>
        /// 将整数列表转换成分隔符分隔的ID列表字符串返回
        /// </summary>
        /// <param name="this">整数列表</param>
        /// <param name="separator">分隔符，默认【|】</param>
        /// <returns>分隔符分隔的ID列表字符串</returns>
        public static string ToIds(this IList<long> @this, string separator = "|")
        {
            return string.Join("|", @this ?? new List<long>());
        }

        /// <summary>
        /// 将字符串列表转换成分隔符分隔的ID列表字符串返回
        /// </summary>
        /// <param name="this">字符串列表</param>
        /// <param name="separator">分隔符，默认【|】</param>
        /// <returns>分隔符分隔的ID列表字符串</returns>
        public static string ToIds(this IList<string> @this, string separator = "|")
        {
            return string.Join("|", @this ?? new List<string>());
        }
    }
}
