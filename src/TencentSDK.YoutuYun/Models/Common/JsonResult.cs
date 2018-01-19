using TencentSDK.YoutuYun.Enums;

namespace TencentSDK.YoutuYun.Models.Common
{

    /// <summary>
    /// 企业微信 JSON 返回结果
    /// </summary>
    public class JsonResult
    {

        /// <summary>
        /// 返回状态值
        /// </summary>
        public ReturnCode errorcode { get; set; }

        /// <summary>
        /// 返回错误消息
        /// </summary>
        public string errormsg { get; set; }
    }
}
