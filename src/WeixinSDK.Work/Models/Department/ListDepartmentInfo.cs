namespace WeixinSDK.Work.Models.Department
{
    /// <summary>
    /// 获取部门列表的返回部门信息类
    /// </summary>
    public class ListDepartmentInfo
    {
        /// <summary>
        /// 创建的部门id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 父亲部门id。根部门为1
        /// </summary>
        public int parentid { get; set; }

        /// <summary>
        /// 在父部门中的次序值。order值大的排序靠前。值范围是[0, 2^32)
        /// </summary>
        public uint order { get; set; }
    }
}