using WeixinSDK.Work.Enums;

namespace WeixinSDK.Work.Models.Common
{

    /// <summary>
    /// 企业微信 JSON 返回结果
    /// </summary>
    public class JsonResult
    {

        /// <summary>
        /// 返回码
        /// </summary>
        public ReturnCode errcode { get; set; }

        /// <summary>
        /// 对返回码的文本描述内容
        /// </summary>
        public string errmsg { get; set; }
    }
}
