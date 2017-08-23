using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Department
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
