using System.Collections.Generic;
using TencentSDK.Exmail.Models.Common;

namespace TencentSDK.Exmail.Models.User
{
    /// <summary>
    /// 获取部门成员详情的返回结果类
    /// </summary>
    public class ListUserResult : JsonResult
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        public List<GetUserResult> userlist { get; set; }
    }
}
