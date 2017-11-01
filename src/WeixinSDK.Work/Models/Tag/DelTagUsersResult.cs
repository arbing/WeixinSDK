using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 删除标签成员的返回结果类
    /// </summary>
    public class DelTagUsersResult : JsonResult
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
