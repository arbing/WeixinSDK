namespace TencentSDK.Exmail.Enums
{
    /// <summary>
    /// 腾讯企业邮箱返回码
    /// </summary>
    public enum ReturnCode
    {
        /// <summary>
        /// 系统繁忙
        /// </summary>
        系统繁忙 = -1,

        /// <summary>
        /// 请求成功
        /// </summary>
        请求成功 = 0,

        /// <summary>
        /// 获取access_token时CorpSecret错误_或者access_token无效
        /// </summary>
        获取access_token时CorpSecret错误_或者access_token无效 = 40001,

        /// <summary>
        /// 不合法的UserID
        /// </summary>
        不合法的UserID = 40003,

        /// <summary>
        /// 不合法的corpid
        /// </summary>
        不合法的corpid = 40013,

        /// <summary>
        /// 不合法的access_token
        /// </summary>
        不合法的access_token = 40014,

        /// <summary>
        /// 不合法的callbackurl或者callbackurl验证失败
        /// </summary>
        不合法的callbackurl或者callbackurl验证失败 = 40057,

        /// <summary>
        /// 无效secert
        /// </summary>
        无效secert = 40091,

        /// <summary>
        /// 接口调用超过限制
        /// </summary>
        接口调用超过限制 = 45009,

        /// <summary>
        /// 帐号数量超过上限
        /// </summary>
        帐号数量超过上限 = 45024,

        /// <summary>
        /// 企业已禁用
        /// </summary>
        企业已禁用 = 50005,

        /// <summary>
        /// 部门长度不符合限制
        /// </summary>
        部门长度不符合限制 = 60001,

        /// <summary>
        /// 部门层级深度超过限制
        /// </summary>
        部门层级深度超过限制 = 60002,

        /// <summary>
        /// 部门不存在
        /// </summary>
        部门不存在 = 60003,

        /// <summary>
        /// 父部门不存在
        /// </summary>
        父部门不存在 = 60004,

        /// <summary>
        /// 不允许删除有成员的部门
        /// </summary>
        不允许删除有成员的部门 = 60005,

        /// <summary>
        /// 不允许删除有子部门的部门
        /// </summary>
        不允许删除有子部门的部门 = 60006,

        /// <summary>
        /// 不允许删除根部门
        /// </summary>
        不允许删除根部门 = 60007,

        /// <summary>
        /// 部门名称已存在
        /// </summary>
        部门名称已存在 = 60008,

        /// <summary>
        /// 部门名称含有非法字符
        /// </summary>
        部门名称含有非法字符 = 60009,

        /// <summary>
        /// 部门存在循环关系
        /// </summary>
        部门存在循环关系 = 60010,

        /// <summary>
        /// UserID已存在
        /// </summary>
        UserID已存在 = 60102,

        /// <summary>
        /// 手机号码不合法
        /// </summary>
        手机号码不合法 = 60103,

        /// <summary>
        /// UserID不存在
        /// </summary>
        UserID不存在 = 60111,

        /// <summary>
        /// 成员姓名不合法
        /// </summary>
        成员姓名不合法 = 60112,

        /// <summary>
        /// 性别不合法
        /// </summary>
        性别不合法 = 60114,

        /// <summary>
        /// 无效的部门id
        /// </summary>
        无效的部门id = 60123,

        /// <summary>
        /// 无效的父部门id
        /// </summary>
        无效的父部门id = 60124,

        /// <summary>
        /// 非法部门名字_长度超过限制、重名等_重名包括与csv文件中同级部门重名或者与旧组织架构包含成员的同级部门重名
        /// </summary>
        非法部门名字_长度超过限制_重名等_重名包括与csv文件中同级部门重名或者与旧组织架构包含成员的同级部门重名 = 60125,

        /// <summary>
        /// 创建部门失败
        /// </summary>
        创建部门失败 = 60126,

        /// <summary>
        /// 缺少部门id
        /// </summary>
        缺少部门id = 60127,

        /// <summary>
        /// Userid与别名冲突
        /// </summary>
        Userid与别名冲突 = 600001,

        /// <summary>
        /// Userid与Groupid冲突
        /// </summary>
        Userid与Groupid冲突 = 600002,

        /// <summary>
        /// 无效密码或者是弱密码
        /// </summary>
        无效密码或者是弱密码 = 600003,

        /// <summary>
        /// 别名无效
        /// </summary>
        别名无效 = 600004,

        /// <summary>
        /// 别名与userid或者Groupid冲突
        /// </summary>
        别名与userid或者Groupid冲突 = 600005,

        /// <summary>
        /// 别名数量达到上限
        /// </summary>
        别名数量达到上限 = 600006,

        /// <summary>
        /// Groupid无效
        /// </summary>
        Groupid无效 = 600007,

        /// <summary>
        /// 邮件群组不存在
        /// </summary>
        邮件群组不存在 = 600008,

        /// <summary>
        /// 群组成员为空
        /// </summary>
        群组成员为空 = 600009,

        /// <summary>
        /// Userlist无效_可能是个别成员无效
        /// </summary>
        Userlist无效_可能是个别成员无效 = 600010,

        /// <summary>
        /// Grouplist无效_可能是个别成员无效
        /// </summary>
        Grouplist无效_可能是个别成员无效 = 600011,

        /// <summary>
        /// Partylist无效_可能是个别成员无效
        /// </summary>
        Partylist无效_可能是个别成员无效 = 600012,

        /// <summary>
        /// 群发权限类型无效
        /// </summary>
        群发权限类型无效 = 600013,

        /// <summary>
        /// 群发权限成员无效
        /// </summary>
        群发权限成员无效 = 600014,

        /// <summary>
        /// 邮件群组已存在
        /// </summary>
        邮件群组已存在 = 600015,

        /// <summary>
        /// Userlist部分成员未找到
        /// </summary>
        Userlist部分成员未找到 = 600016,

        /// <summary>
        /// Partylist部分成员未找到
        /// </summary>
        Partylist部分成员未找到 = 600017,

        /// <summary>
        /// Grouplist部分成员未找到
        /// </summary>
        Grouplist部分成员未找到 = 600018,

        /// <summary>
        /// 邮件群组名称含有非法字符
        /// </summary>
        邮件群组名称含有非法字符 = 600019,

        /// <summary>
        /// 邮件群组存在循环
        /// </summary>
        邮件群组存在循环 = 600020,

        /// <summary>
        /// 邮件群组嵌套超过层数
        /// </summary>
        邮件群组嵌套超过层数 = 600021,

        /// <summary>
        /// 群发权限成员缺失
        /// </summary>
        群发权限成员缺失 = 600023,

        /// <summary>
        /// Groupid与userid或者别名冲突
        /// </summary>
        Groupid与userid或者别名冲突 = 600024,

        /// <summary>
        /// 座机号码无效
        /// </summary>
        座机号码无效 = 600025,

        /// <summary>
        /// 编号无效
        /// </summary>
        编号无效 = 600026,

        /// <summary>
        /// 批量检查的成员数超过限额
        /// </summary>
        批量检查的成员数超过限额 = 600027,

        /// <summary>
        /// 日志查询的时间无效
        /// </summary>
        日志查询的时间无效 = 601001,

        /// <summary>
        /// 日志查询的时间超过限制
        /// </summary>
        日志查询的时间超过限制 = 601002,

        /// <summary>
        /// 日志查询的域名无效
        /// </summary>
        日志查询的域名无效 = 601003,

        /// <summary>
        /// 日志查询的域名不存在
        /// </summary>
        日志查询的域名不存在 = 601004,

        /// <summary>
        /// 应用没有访问此API的权限
        /// </summary>
        应用没有访问此API的权限 = 602005,
    }
}
