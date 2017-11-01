using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 获取标签列表的返回结果类
    /// </summary>
    public class ListTagResult : JsonResult
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        public List<TagInfo> taglist { get; set; }
    }
}
