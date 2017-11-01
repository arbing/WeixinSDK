using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 创建标签返回结果类
    /// </summary>
    public class CreateTagResult : JsonResult
    {
        /// <summary>
        /// 创建的标签id
        /// </summary>
        public int tagid { get; set; }
    }
}
