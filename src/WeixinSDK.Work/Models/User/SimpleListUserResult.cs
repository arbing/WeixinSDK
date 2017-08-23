using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.User
{
    /// <summary>
    /// 获取部门成员的返回结果类
    /// </summary>
    public class SimpleListUserResult : JsonResult
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        public List<SimpleListUserInfo> userlist { get; set; }
    }
}
