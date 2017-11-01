namespace WeixinSDK.Work.Enums
{
    /// <summary>
    /// 企业微信返回码
    /// </summary>
    public enum ReturnCode
    {
        /// <summary>
        /// 系统繁忙
        /// 排查方法：服务器暂不可用，建议稍候重试。建议重试次数不超过3次。
        /// </summary>
        系统繁忙 = -1,

        /// <summary>
        /// 请求成功
        /// 排查方法：接口调用成功
        /// </summary>
        请求成功 = 0,

        /// <summary>
        /// 不合法的secret参数
        /// 排查方法：secret在应用详情/通讯录管理助手可查看
        /// </summary>
        不合法的secret参数 = 40001,

        /// <summary>
        /// 无效的UserID
        /// 排查方法：查看帮助
        /// </summary>
        无效的UserID = 40003,

        /// <summary>
        /// 不合法的媒体文件类型
        /// 排查方法：不满足系统文件要求。参考：上传的媒体文件限制
        /// </summary>
        不合法的媒体文件类型 = 40004,

        /// <summary>
        /// 不合法的type参数
        /// 排查方法：合法的type取值，参考：上传临时素材
        /// </summary>
        不合法的type参数 = 40005,

        /// <summary>
        /// 不合法的文件大小
        /// 排查方法：系统文件要求，参考：上传的媒体文件限制
        /// </summary>
        不合法的文件大小 = 40006,

        /// <summary>
        /// 不合法的media_id参数
        /// 排查方法：查看帮助
        /// </summary>
        不合法的media_id参数 = 40007,

        /// <summary>
        /// 不合法的msgtype参数
        /// 排查方法：合法的msgtype取值，参考：消息类型
        /// </summary>
        不合法的msgtype参数 = 40008,

        /// <summary>
        /// 不合法的CorpID
        /// 排查方法：需确认CorpID是否填写正确，在 web管理端-设置 可查看
        /// </summary>
        不合法的CorpID = 40013,

        /// <summary>
        /// 不合法的access_token
        /// 排查方法：查看帮助
        /// </summary>
        不合法的access_token = 40014,

        /// <summary>
        /// 不合法的按钮个数
        /// 排查方法：菜单按钮1-3个
        /// </summary>
        不合法的按钮个数 = 40016,

        /// <summary>
        /// 不合法的按钮类型
        /// 排查方法：支持的类型，参考：按钮类型
        /// </summary>
        不合法的按钮类型 = 40017,

        /// <summary>
        /// 不合法的按钮名字长度
        /// 排查方法：长度应不超过16个字节
        /// </summary>
        不合法的按钮名字长度 = 40018,

        /// <summary>
        /// 不合法的按钮KEY长度
        /// 排查方法：长度应不超过128字节
        /// </summary>
        不合法的按钮KEY长度 = 40019,

        /// <summary>
        /// 不合法的按钮URL长度
        /// 排查方法：长度应不超过1024字节
        /// </summary>
        不合法的按钮URL长度 = 40020,

        /// <summary>
        /// 不合法的子菜单级数
        /// 排查方法：只能包含一级菜单和二级菜单
        /// </summary>
        不合法的子菜单级数 = 40022,

        /// <summary>
        /// 不合法的子菜单按钮个数
        /// 排查方法：子菜单按钮1-5个
        /// </summary>
        不合法的子菜单按钮个数 = 40023,

        /// <summary>
        /// 不合法的子菜单按钮类型
        /// 排查方法：支持的类型，参考：按钮类型
        /// </summary>
        不合法的子菜单按钮类型 = 40024,

        /// <summary>
        /// 不合法的子菜单按钮名字长度
        /// 排查方法：支持的类型，参考：按钮类型
        /// </summary>
        不合法的子菜单按钮名字长度 = 40025,

        /// <summary>
        /// 不合法的子菜单按钮KEY长度
        /// 排查方法：长度应不超过60个字节
        /// </summary>
        不合法的子菜单按钮KEY长度 = 40026,

        /// <summary>
        /// 不合法的子菜单按钮URL长度
        /// 排查方法：长度应不超过1024字节
        /// </summary>
        不合法的子菜单按钮URL长度 = 40027,

        /// <summary>
        /// 不合法的oauth_code
        /// 排查方法：查看帮助
        /// </summary>
        不合法的oauth_code = 40029,

        /// <summary>
        /// 不合法的UserID列表
        /// 排查方法：指定的UserID列表，至少存在一个UserID不在通讯录中
        /// </summary>
        不合法的UserID列表 = 40031,

        /// <summary>
        /// 不合法的UserID列表长度
        /// 排查方法：查看帮助
        /// </summary>
        不合法的UserID列表长度 = 40032,

        /// <summary>
        /// 不合法的请求字符
        /// 排查方法：不能包含\uxxxx格式的字符
        /// </summary>
        不合法的请求字符 = 40033,

        /// <summary>
        /// 不合法的子菜单url域名
        /// 排查方法：查看帮助
        /// </summary>
        不合法的子菜单url域名 = 40054,

        /// <summary>
        /// 不合法的菜单url域名
        /// 排查方法：查看帮助
        /// </summary>
        不合法的菜单url域名 = 40055,

        /// <summary>
        /// 不合法的agentid
        /// 排查方法：查看帮助
        /// </summary>
        不合法的agentid = 40056,

        /// <summary>
        /// 不合法的callbackurl或者callbackurl验证失败
        /// 排查方法：可自助到开发调试工具重现
        /// </summary>
        不合法的callbackurl或者callbackurl验证失败 = 40057,

        /// <summary>
        /// 不合法的参数
        /// 排查方法：传递参数不符合系统要求，需要参照具体API接口说明
        /// </summary>
        不合法的参数 = 40058,

        /// <summary>
        /// 不合法的上报地理位置标志位
        /// 排查方法：开关标志位只能填 0 或者 1
        /// </summary>
        不合法的上报地理位置标志位 = 40059,

        /// <summary>
        /// 参数为空
        /// 排查方法：查看帮助
        /// </summary>
        参数为空 = 40063,

        /// <summary>
        /// 不合法的部门列表
        /// 排查方法：部门列表为空，或者至少存在一个部门ID不存在于通讯录中
        /// </summary>
        不合法的部门列表 = 40066,

        /// <summary>
        /// 不合法的标签ID
        /// 排查方法：标签ID未指定，或者指定的标签ID不存在
        /// </summary>
        不合法的标签ID = 40068,

        /// <summary>
        /// 不合法的标签名字
        /// 排查方法：标签名字已经存在
        /// </summary>
        不合法的标签名字 = 40071,

        /// <summary>
        /// 不合法的标签名字长度
        /// 排查方法：不允许为空，最大长度限制为32个字（汉字或英文字母）
        /// </summary>
        不合法的标签名字长度 = 40072,

        /// <summary>
        /// 不合法的openid
        /// 排查方法：openid不存在，需确认获取来源
        /// </summary>
        不合法的openid = 40073,

        /// <summary>
        /// news消息不支持保密消息类型
        /// 排查方法：图文消息支持保密类型需改用mpnews
        /// </summary>
        news消息不支持保密消息类型 = 40074,

        /// <summary>
        /// 不合法的pre_auth_code参数
        /// 排查方法：预授权码不存在，参考：获取预授权码
        /// </summary>
        不合法的pre_auth_code参数 = 40077,

        /// <summary>
        /// 不合法的auth_code参数
        /// 排查方法：需确认获取来源，并且只能消费一次
        /// </summary>
        不合法的auth_code参数 = 40078,

        /// <summary>
        /// 不合法的suite_secret
        /// 排查方法：套件secret可在第三方管理端套件详情查看
        /// </summary>
        不合法的suite_secret = 40080,

        /// <summary>
        /// 不合法的suite_token
        /// 排查方法：查看帮助
        /// </summary>
        不合法的suite_token = 40082,

        /// <summary>
        /// 不合法的suite_id
        /// 排查方法：suite_id不存在
        /// </summary>
        不合法的suite_id = 40083,

        /// <summary>
        /// 不合法的permanent_code参数
        /// 排查方法：查看帮助
        /// </summary>
        不合法的permanent_code参数 = 40084,

        /// <summary>
        /// 不合法的的suite_ticket参数
        /// 排查方法：suite_ticket不存在或者已失效
        /// </summary>
        不合法的的suite_ticket参数 = 40085,

        /// <summary>
        /// 不合法的第三方应用appid
        /// 排查方法：至少有一个不存在应用id
        /// </summary>
        不合法的第三方应用appid = 40086,

        /// <summary>
        /// 导入文件存在不合法的内容
        /// 排查方法：查看帮助
        /// </summary>
        导入文件存在不合法的内容 = 40092,

        /// <summary>
        /// 不合法的jsapi_ticket参数
        /// 排查方法：ticket已失效，或者拼写错误
        /// </summary>
        不合法的jsapi_ticket参数 = 40093,

        /// <summary>
        /// 不合法的URL
        /// 排查方法：缺少主页URL参数
        /// </summary>
        不合法的URL = 40094,

        /// <summary>
        /// 缺少access_token参数
        /// 排查方法：-
        /// </summary>
        缺少access_token参数 = 41001,

        /// <summary>
        /// 缺少corpid参数
        /// 排查方法：-
        /// </summary>
        缺少corpid参数 = 41002,

        /// <summary>
        /// 缺少secret参数
        /// 排查方法：-
        /// </summary>
        缺少secret参数 = 41004,

        /// <summary>
        /// 缺少auth code参数
        /// 排查方法：-
        /// </summary>
        缺少auth_code参数 = 41008,

        /// <summary>
        /// 缺少userid参数
        /// 排查方法：-
        /// </summary>
        缺少userid参数 = 41009,

        /// <summary>
        /// 缺少url参数
        /// 排查方法：-
        /// </summary>
        缺少url参数 = 41010,

        /// <summary>
        /// 缺少agentid参数
        /// 排查方法：-
        /// </summary>
        缺少agentid参数 = 41011,

        /// <summary>
        /// 缺少title参数
        /// 排查方法：-
        /// </summary>
        缺少title参数 = 41016,

        /// <summary>
        /// 缺少tagid参数
        /// 排查方法：-
        /// </summary>
        缺少tagid参数 = 41017,

        /// <summary>
        /// 缺少suite_id参数
        /// 排查方法：-
        /// </summary>
        缺少suite_id参数 = 41021,

        /// <summary>
        /// 缺少permanent_code参数
        /// 排查方法：-
        /// </summary>
        缺少permanent_code参数 = 41025,

        /// <summary>
        /// access_token已过期
        /// 排查方法：access_token有时效性，需要重新获取一次
        /// </summary>
        access_token已过期 = 42001,

        /// <summary>
        /// pre_auth_code已过期
        /// 排查方法：pre_auth_code有时效性，需要重新获取一次
        /// </summary>
        pre_auth_code已过期 = 42007,

        /// <summary>
        /// suite_access_token已过期
        /// 排查方法：suite_access_token有时效性，需要重新获取一次
        /// </summary>
        suite_access_token已过期 = 42009,

        /// <summary>
        /// 指定的userid未关注微信插件
        /// 排查方法：需要成员关注微信插件才能获取openid
        /// </summary>
        指定的userid未关注微信插件 = 43004,

        /// <summary>
        /// 文本消息content参数为空
        /// 排查方法：发文本消息content为必填参数，且不能为空
        /// </summary>
        文本消息content参数为空 = 44004,

        /// <summary>
        /// 多媒体文件大小超过限制
        /// 排查方法：图片不可超过5M；音频不可超过5M；文件不可超过20M
        /// </summary>
        多媒体文件大小超过限制 = 45001,

        /// <summary>
        /// 消息内容大小超过限制
        /// 排查方法：查看帮助
        /// </summary>
        消息内容大小超过限制 = 45002,

        /// <summary>
        /// 应用description参数长度不符合系统限制
        /// 排查方法：设置应用若带有description参数，则不允许为空
        /// </summary>
        应用description参数长度不符合系统限制 = 45004,

        /// <summary>
        /// 语音播放时间超过限制
        /// 排查方法：语音播放时长不能超过60秒
        /// </summary>
        语音播放时间超过限制 = 45007,

        /// <summary>
        /// 图文消息的文章数量不符合系统限制
        /// 排查方法：图文消息的文章数量不能超过8条
        /// </summary>
        图文消息的文章数量不符合系统限制 = 45008,

        /// <summary>
        /// 接口调用超过限制
        /// 排查方法：查看帮助
        /// </summary>
        接口调用超过限制 = 45009,

        /// <summary>
        /// 应用name参数长度不符合系统限制
        /// 排查方法：设置应用若带有name参数，则不允许为空
        /// </summary>
        应用name参数长度不符合系统限制 = 45022,

        /// <summary>
        /// 帐号数量超过上限
        /// 排查方法：查看帮助
        /// </summary>
        帐号数量超过上限 = 45024,

        /// <summary>
        /// 触发删除用户数的保护
        /// 排查方法：限制参考：全量覆盖成员
        /// </summary>
        触发删除用户数的保护 = 45026,

        /// <summary>
        /// 图文消息author参数长度超过限制
        /// 排查方法：最长64个字节
        /// </summary>
        图文消息author参数长度超过限制 = 45032,

        /// <summary>
        /// 菜单未设置
        /// 排查方法：菜单需发布后才能获取到数据
        /// </summary>
        菜单未设置 = 46003,

        /// <summary>
        /// API接口无权限调用
        /// 排查方法：查看帮助
        /// </summary>
        API接口无权限调用 = 48002,

        /// <summary>
        /// 不合法的suite_id
        /// 排查方法：确认suite_access_token由指定的suite_id生成
        /// </summary>
        不合法的suite_id_ = 48003,

        /// <summary>
        /// 授权关系无效
        /// 排查方法：可能是无授权或授权已被取消
        /// </summary>
        授权关系无效 = 48004,

        /// <summary>
        /// API接口已废弃
        /// 排查方法：接口已不再支持，建议改用新接口或者新方案
        /// </summary>
        API接口已废弃 = 48005,

        /// <summary>
        /// redirect_url未登记可信域名
        /// 排查方法：查看帮助
        /// </summary>
        redirect_url未登记可信域名 = 50001,

        /// <summary>
        /// 成员不在权限范围
        /// 排查方法：请检查应用或管理组的权限范围
        /// </summary>
        成员不在权限范围 = 50002,

        /// <summary>
        /// 应用已禁用
        /// 排查方法：-
        /// </summary>
        应用已禁用 = 50003,

        /// <summary>
        /// 部门长度不符合限制
        /// 排查方法：部门名称不能为空且长度不能超过64个字
        /// </summary>
        部门长度不符合限制 = 60001,

        /// <summary>
        /// 部门ID不存在
        /// 排查方法：需要确认部门ID是否有带，并且存在通讯录中
        /// </summary>
        部门ID不存在 = 60003,

        /// <summary>
        /// 父部门不存在
        /// 排查方法：需要确认父亲部门ID是否有带，并且存在通讯录中
        /// </summary>
        父部门不存在 = 60004,

        /// <summary>
        /// 部门下存在成员
        /// 排查方法：不允许删除有成员的部门
        /// </summary>
        部门下存在成员 = 60005,

        /// <summary>
        /// 部门下存在子部门
        /// 排查方法：不允许删除有子部门的部门
        /// </summary>
        部门下存在子部门 = 60006,

        /// <summary>
        /// 不允许删除根部门
        /// 排查方法：-
        /// </summary>
        不允许删除根部门 = 60007,

        /// <summary>
        /// 部门已存在
        /// 排查方法：部门ID或者部门名称已存在
        /// </summary>
        部门已存在 = 60008,

        /// <summary>
        /// 部门名称含有非法字符
        /// 排查方法：不能含有 \:?*“<>| 等字符
        /// </summary>
        部门名称含有非法字符 = 60009,

        /// <summary>
        /// 部门存在循环关系
        /// 排查方法：查看帮助
        /// </summary>
        部门存在循环关系 = 60010,

        /// <summary>
        /// 指定的成员/部门/标签参数无权限
        /// 排查方法：查看帮助
        /// </summary>
        指定的成员_部门_标签参数无权限 = 60011,

        /// <summary>
        /// 不允许删除默认应用
        /// 排查方法：默认应用的id为0
        /// </summary>
        不允许删除默认应用 = 60012,

        /// <summary>
        /// 访问ip不在白名单之中
        /// 排查方法：请确认访问ip是否在套件的ip白名单内
        /// </summary>
        访问ip不在白名单之中 = 60020,

        /// <summary>
        /// UserID已存在
        /// 排查方法：-
        /// </summary>
        UserID已存在 = 60102,

        /// <summary>
        /// 手机号码不合法
        /// 排查方法：长度不超过32位，字符仅支持数字，加号和减号
        /// </summary>
        手机号码不合法 = 60103,

        /// <summary>
        /// 手机号码已存在
        /// 排查方法：-
        /// </summary>
        手机号码已存在 = 60104,

        /// <summary>
        /// 邮箱不合法
        /// 排查方法：长度不超过64位，且为有效的email格式
        /// </summary>
        邮箱不合法 = 60105,

        /// <summary>
        /// 邮箱已存在
        /// 排查方法：-
        /// </summary>
        邮箱已存在 = 60106,

        /// <summary>
        /// 用户所属部门数量超过限制
        /// 排查方法：用户同时归属部门不超过20个
        /// </summary>
        用户所属部门数量超过限制 = 60110,

        /// <summary>
        /// UserID不存在
        /// 排查方法：UserID参数为空，或者不存在通讯录中
        /// </summary>
        UserID不存在 = 60111,

        /// <summary>
        /// 成员name参数不合法
        /// 排查方法：不能为空，且不能超过64字节
        /// </summary>
        成员name参数不合法 = 60112,

        /// <summary>
        /// 无效的部门id
        /// 排查方法：部门不存在通讯录中
        /// </summary>
        无效的部门id = 60123,

        /// <summary>
        /// 无效的父部门id
        /// 排查方法：父部门不存在通讯录中
        /// </summary>
        无效的父部门id = 60124,

        /// <summary>
        /// 非法部门名字
        /// 排查方法：不能为空，且不能超过64字节，且不能含有\:*?”<>|等字符
        /// </summary>
        非法部门名字 = 60125,

        /// <summary>
        /// 缺少department参数
        /// 排查方法：-
        /// </summary>
        缺少department参数 = 60127,

        /// <summary>
        /// 成员手机和邮箱都为空
        /// 排查方法：成员手机和邮箱至少有个非空
        /// </summary>
        成员手机和邮箱都为空 = 60129,

        /// <summary>
        /// 发票已被其他公众号锁定
        /// 排查方法：查看帮助
        /// </summary>
        发票已被其他公众号锁定 = 72023,

        /// <summary>
        /// 发票状态错误
        /// 排查方法：reimburse_status状态错误，参考：更新发票状态
        /// </summary>
        发票状态错误 = 72024,

        /// <summary>
        /// 存在发票不属于该用户
        /// 排查方法：只能批量更新该openid的发票，参考：批量更新发票状态
        /// </summary>
        存在发票不属于该用户 = 72037,

        /// <summary>
        /// 可信域名不正确，或者无ICP备案
        /// 排查方法：查看帮助
        /// </summary>
        可信域名不正确_或者无ICP备案 = 80001,

        /// <summary>
        /// 部门下的结点数超过限制（3W）
        /// 排查方法：-
        /// </summary>
        部门下的结点数超过限制_3W = 81001,

        /// <summary>
        /// 部门最多15层
        /// 排查方法：-
        /// </summary>
        部门最多15层 = 81002,

        /// <summary>
        /// 无权限操作标签
        /// 排查方法：查看帮助
        /// </summary>
        无权限操作标签 = 81011,

        /// <summary>
        /// 不合法的PartyID列表长度
        /// 排查方法：发消息，单次不能超过100个部门
        /// </summary>
        不合法的PartyID列表长度 = 82002,

        /// <summary>
        /// 不合法的TagID列表长度
        /// 排查方法：发消息，单次不能超过100个标签
        /// </summary>
        不合法的TagID列表长度 = 82003,

        /// <summary>
        /// 缺少templateid参数
        /// 排查方法：-
        /// </summary>
        缺少templateid参数 = 84019,

        /// <summary>
        /// templateid不存在
        /// 排查方法：确认参数是否有带，并且已创建
        /// </summary>
        templateid不存在 = 84020,

        /// <summary>
        /// 缺少register_code参数
        /// 排查方法：-
        /// </summary>
        缺少register_code参数 = 84021,

        /// <summary>
        /// 无效的register_code参数
        /// 排查方法：-
        /// </summary>
        无效的register_code参数 = 84022,

        /// <summary>
        /// 不允许调用设置通讯录同步完成接口
        /// 排查方法：-
        /// </summary>
        不允许调用设置通讯录同步完成接口 = 84023,

        /// <summary>
        /// 无注册信息
        /// 排查方法：查看帮助
        /// </summary>
        无注册信息 = 84024,

        /// <summary>
        /// 包含不合法的词语
        /// 排查方法：-
        /// </summary>
        包含不合法的词语 = 85002,

        /// <summary>
        /// 每企业每个月设置的可信域名不可超过20个
        /// 排查方法：-
        /// </summary>
        每企业每个月设置的可信域名不可超过20个 = 85004,

        /// <summary>
        /// 可信域名未通过所有权校验
        /// 排查方法：查看帮助
        /// </summary>
        可信域名未通过所有权校验 = 85005,
    }
}
