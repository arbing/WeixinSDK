namespace TencentSDK.Exmail.Models.Department
{
    /// <summary>
    /// 获取部门列表的返回部门信息类
    /// </summary>
    public class ListDepartmentInfo
    {
        /// <summary>
        /// 创建的部门id
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 父亲部门id。根部门为1
        /// </summary>
        public long parentid { get; set; }
        /// <summary>
        /// 在父部门中的次序值。order值小的排序靠前
        /// </summary>
        public uint order { get; set; }
    }
}