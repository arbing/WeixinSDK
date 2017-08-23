using System.Collections.Generic;
using TencentSDK.Exmail.Models.Common;

namespace TencentSDK.Exmail.Models.Department
{
    /// <summary>
    /// 获取部门列表的返回结果类
    /// </summary>
    public class ListDepartmentResult : JsonResult
    {
        /// <summary>
        /// 部门列表数据。
        /// </summary>
        public List<ListDepartmentInfo> department;
    }
}
