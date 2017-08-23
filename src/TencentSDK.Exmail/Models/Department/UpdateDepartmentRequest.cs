namespace TencentSDK.Exmail.Models.Department
{
    /// <summary>
    /// 更新部门请求参数类
    /// </summary>
    public class UpdateDepartmentRequest
    {
        /// <summary>
        /// 部门id。必填
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 更新的部门名称。长度限制为1~64个字节，字符不能包括\:*?"&lt;&gt;｜。修改部门名称时指定该参数
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 父部门id。id为1可表示根部门
        /// </summary>
        public long? parentid { get; set; }
        /// <summary>
        /// 在父部门中的次序值。order值小的排序靠前。
        /// </summary>
        public uint? order { get; set; }
    }
}
