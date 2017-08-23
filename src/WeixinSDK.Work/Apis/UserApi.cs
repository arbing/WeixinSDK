using System.Collections.Generic;
using WeixinSDK.Work.Common;
using WeixinSDK.Work.Models.Common;
using WeixinSDK.Work.Models.User;

namespace WeixinSDK.Work.Apis
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
        /// 文档：https://work.weixin.qq.com/api/doc#10018
        /// </summary>
        /// <param name="user">成员信息</param>
        /// <returns>返回结果</returns>
        public JsonResult Create(CreateUserRequest user)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/user/create", new {accessToken.access_token}, user);
        }

        /// <summary>
        /// 读取成员
        /// 文档：https://work.weixin.qq.com/api/doc#10019
        /// </summary>
        /// <param name="userid">员工UserID</param>
        /// <returns>返回结果</returns>
        public GetUserResult Get(string userid)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<GetUserResult>("/user/get", new {accessToken.access_token, userid});
        }

        /// <summary>
        /// 更新成员
        /// 文档：https://work.weixin.qq.com/api/doc#10020
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
        /// 文档：https://work.weixin.qq.com/api/doc#10030
        /// </summary>
        /// <param name="userid">员工UserID</param>
        /// <returns>返回结果</returns>
        public JsonResult Delete(string userid)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/user/delete", new {accessToken.access_token, userid}, null);
        }

        /// <summary>
        /// 批量删除成员
        /// 文档：https://work.weixin.qq.com/api/doc#10060
        /// </summary>
        /// <param name="userids">成员UserID列表。对应管理端的帐号。（最多支持200个）</param>
        /// <returns>返回结果</returns>
        public JsonResult BatchDelete(List<string> userids)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/user/batchdelete", new {accessToken.access_token},
                new {useridlist = userids});
        }

        /// <summary>
        /// 获取部门成员
        /// 文档：https://work.weixin.qq.com/api/doc#10061
        /// </summary>
        /// <param name="department_id">获取的部门id</param>
        /// <param name="fetch_child">1/0：是否递归获取子部门下面的成员</param>
        /// <returns>返回结果</returns>
        public SimpleListUserResult SimpleList(int department_id, int fetch_child)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<SimpleListUserResult>("/user/simplelist",
                new {accessToken.access_token, department_id, fetch_child});
        }

        /// <summary>
        /// 获取部门成员详情
        /// 文档：https://work.weixin.qq.com/api/doc#10063
        /// </summary>
        /// <param name="department_id">获取的部门id</param>
        /// <param name="fetch_child">1/0：是否递归获取子部门下面的成员</param>
        /// <returns>返回结果</returns>
        public ListUserResult List(int department_id, int fetch_child)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<ListUserResult>("/user/list",
                new {accessToken.access_token, department_id, fetch_child});
        }

        /// <summary>
        /// 通过code获取用户信息
        /// 文档：http://work.weixin.qq.com/api/doc#10719/开启网页接入
        /// </summary>
        /// <param name="code">通过成员授权获取到的code，每次成员授权带上的code将不一样，code只能使用一次，5分钟未被使用自动过期</param>
        /// <returns>返回结果</returns>
        public GetUserInfoResult GetUserInfo(string code)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<GetUserInfoResult>("/user/getuserinfo", new { accessToken.access_token, code });
        }
    }
}
