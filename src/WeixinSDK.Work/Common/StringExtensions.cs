using System;
using System.Collections.Generic;
using System.Linq;

namespace WeixinSDK.Work.Common
{
    internal static class StringExtensions
    {
        /// <summary>
        /// 将分隔符分隔的ID列表字符串转换成整数列表返回
        /// </summary>
        /// <param name="this">分隔符分隔的ID列表字符串</param>
        /// <param name="separator">分隔符，默认【|】</param>
        /// <returns>整数列表</returns>
        public static IList<int> ToInt32List(this string @this, string separator = "|")
        {
            return @this.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s))
                .ToList();
        }

        /// <summary>
        /// 将分隔符分隔的ID列表字符串转换成整数列表返回
        /// </summary>
        /// <param name="this">分隔符分隔的ID列表字符串</param>
        /// <param name="separator">分隔符，默认【|】</param>
        /// <returns>整数列表</returns>
        public static IList<long> ToInt64List(this string @this, string separator = "|")
        {
            return @this.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt64(s))
                .ToList();
        }

        /// <summary>
        /// 将分隔符分隔的列表字符串转换成字符串列表返回
        /// </summary>
        /// <param name="this">分隔符分隔的列表字符串</param>
        /// <param name="separator">分隔符，默认【|】</param>
        /// <returns>字符串列表</returns>
        public static IList<string> ToStringList(this string @this, string separator = "|")
        {
            return @this.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries).Select(s => s)
                .ToList();
        }
    }
}
