using TencentSDK.Exmail.Common;
using TencentSDK.Exmail.Models.Common;
using TencentSDK.Exmail.Models.User;

namespace TencentSDK.Exmail.Apis
{
    /// <summary>
    /// 成员管理接口
    /// </summary>
    public class UserApi : ApiBase
    {
        /// <summary>
        /// 实例化成员管理接口
        /// </summary>
        /// <param name="client"></param>
        public UserApi(ApiClientBase client) : base(client)
        {
        }

        /// <summary>
        /// 创建成员
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10014
        /// </summary>
        /// <param name="user">成员信息</param>
        /// <returns>返回结果</returns>
        public JsonResult Create(CreateUserRequest user)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/user/create", new {accessToken.access_token}, user);
        }

        /// <summary>
        /// 更新成员
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10015
        /// </summary>
        /// <param name="user">成员信息</param>
        /// <returns>返回结果</returns>
        public JsonResult Update(UpdateUserRequest user)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/user/update", new {accessToken.access_token}, user);
        }

        /// <summary>
        /// 删除成员
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10016
        /// </summary>
        /// <param name="userid">成员UserID。企业邮帐号名，邮箱格式</param>
        /// <returns>返回结果</returns>
        public JsonResult Delete(string userid)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/user/delete", new {accessToken.access_token, userid}, null);
        }

        /// <summary>
        /// 读取成员
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10017
        /// </summary>
        /// <param name="userid">成员UserID。企业邮帐号名，邮箱格式</param>
        /// <returns>返回结果</returns>
        public GetUserResult Get(string userid)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<GetUserResult>("/user/get", new { accessToken.access_token, userid });
        }

        /// <summary>
        /// 获取部门成员
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10018
        /// </summary>
        /// <param name="department_id">获取的部门id。id为1时可获取根部门下的成员</param>
        /// <param name="fetch_child">1/0：是否递归获取子部门下面的成员</param>
        /// <returns>返回结果</returns>
        public SimpleListUserResult SimpleList(long department_id, int fetch_child)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<SimpleListUserResult>("/user/simplelist",
                new {accessToken.access_token, department_id, fetch_child});
        }

        /// <summary>
        /// 获取部门成员详情
        /// 文档：https://exmail.qq.com/qy_mng_logic/doc#10019
        /// </summary>
        /// <param name="department_id">获取的部门id。id为1时可获取根部门下的成员</param>
        /// <param name="fetch_child">1/0：是否递归获取子部门下面的成员</param>
        /// <returns>返回结果</returns>
        public ListUserResult List(long department_id, int fetch_child)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<ListUserResult>("/user/list",
                new {accessToken.access_token, department_id, fetch_child});
        }
    }
}
