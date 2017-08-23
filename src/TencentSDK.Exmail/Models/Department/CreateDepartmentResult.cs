using TencentSDK.Exmail.Models.Common;

namespace TencentSDK.Exmail.Models.Department
{
    /// <summary>
    /// 创建部门返回结果类
    /// </summary>
    public class CreateDepartmentResult : JsonResult
    {
        /// <summary>
        /// 创建的部门id。id为64位整型数
        /// </summary>
        public long id { get; set; }
    }
}
