using TencentSDK.Exmail.Common;
using TencentSDK.Exmail.Models.Common;
using TencentSDK.Exmail.Models.Department;

namespace TencentSDK.Exmail.Apis
{
    /// <summary>
    /// 部门管理接口
    /// </summary>
    public class DepartmentApi : ApiBase
    {
        /// <summary>
        /// 实例化部门管理接口
        /// </summary>
        /// <param name="client"></param>
        public DepartmentApi(ApiClientBase client) : base(client)
        {
        }

        /// <summary>
        /// 创建部门
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10008
        /// </summary>
        /// <param name="department">部门信息</param>
        /// <returns>返回结果</returns>
        public CreateDepartmentResult Create(CreateDepartmentRequest department)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<CreateDepartmentResult>("/department/create", new { accessToken.access_token }, department);
        }

        /// <summary>
        /// 更新部门
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10009
        /// </summary>
        /// <param name="department">部门信息</param>
        /// <returns>返回结果</returns>
        public JsonResult Update(UpdateDepartmentRequest department)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/department/update", new { accessToken.access_token }, department);
        }

        /// <summary>
        /// 删除部门
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10010
        /// </summary>
        /// <param name="id">部门id。（注：不能删除根部门；不能删除含有子部门、成员的部门）</param>
        /// <returns>返回结果</returns>
        public JsonResult Delete(long id)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/department/delete", new { accessToken.access_token, id }, null);
        }

        /// <summary>
        /// 获取部门列表
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10011
        /// </summary>
        /// <param name="id">部门id。获取指定部门及其下的子部门。id为1时可获取根部门下的子部门。</param>
        /// <returns>返回结果</returns>
        public ListDepartmentResult List(long id = 0)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<ListDepartmentResult>("/department/list", new { accessToken.access_token, id });
        }
    }
}
