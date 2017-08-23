using WeixinSDK.Work.Common;
using WeixinSDK.Work.Models.Common;
using WeixinSDK.Work.Models.Department;

namespace WeixinSDK.Work.Apis
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
        /// 文档：https://work.weixin.qq.com/api/doc#10076
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
        /// 文档：https://work.weixin.qq.com/api/doc#10077
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
        /// 文档：https://work.weixin.qq.com/api/doc#10079
        /// </summary>
        /// <param name="id">部门id。（注：不能删除根部门；不能删除含有子部门、成员的部门）</param>
        /// <returns>返回结果</returns>
        public JsonResult Delete(int id)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/department/delete", new { accessToken.access_token, id }, null);
        }

        /// <summary>
        /// 获取部门列表
        /// 文档：https://work.weixin.qq.com/api/doc#10093
        /// </summary>
        /// <param name="id">部门id。获取指定部门及其下的子部门。 如果不填，默认获取全量组织架构</param>
        /// <returns>返回结果</returns>
        public ListDepartmentResult List(int id = 0)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<ListDepartmentResult>("/department/list", new { accessToken.access_token, id });
        }
    }
}
