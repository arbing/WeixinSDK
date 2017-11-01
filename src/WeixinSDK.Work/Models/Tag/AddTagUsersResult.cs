using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 增加标签成员的返回结果类
    /// </summary>
    public class AddTagUsersResult : JsonResult
    {

        /// <summary>
        ///  无效成员ID列表
        /// </summary>
        public string invalidlist { get; set; }

        /// <summary>
        ///  无效部门ID列表
        /// </summary>
        public List<int> invalidparty { get; set; }
    }
}
