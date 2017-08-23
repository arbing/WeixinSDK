using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.User
{
    /// <summary>
    /// 获取成员详情的返回结果类
    /// </summary>
    public class GetUserInfoResult : JsonResult
    {
        /// <summary>
        /// 成员UserID
        /// </summary>
        public string UserId { get; set; }
    }
}
