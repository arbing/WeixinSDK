using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Message
{
    /// <summary>
    /// 发送消息的返回结果类
    /// </summary>
    public class SendMessageResult : JsonResult
    {
        /// <summary>
        /// 无效接收成员ID列表，不区分大小写，返回的列表都统一转为小写。如果部分接收人无权限或不存在，发送仍然执行，但会返回无效的部分
        /// </summary>
        public string invaliduser { get; set; }

        /// <summary>
        ///  无效接收部门ID列表
        /// </summary>
        public string invalidparty { get; set; }

        /// <summary>
        ///  无效接收标签ID列表
        /// </summary>
        public string invalidtag { get; set; }
    }
}
