using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Department
{
    /// <summary>
    /// 创建部门返回结果类
    /// </summary>
    public class CreateDepartmentResult : JsonResult
    {
        /// <summary>
        /// 创建的部门id
        /// </summary>
        public int id { get; set; }
    }
}
