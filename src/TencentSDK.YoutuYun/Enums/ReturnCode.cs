using System.ComponentModel;

namespace TencentSDK.YoutuYun.Enums
{
    /// <summary>
    /// 腾讯企业邮箱返回码
    /// </summary>
    public enum ReturnCode
    {
        /// <summary>
        /// 系统繁忙
        /// 说明：服务器暂不可用，建议稍候重试。建议重试次数不超过3次。
        /// </summary>
        [Description("系统繁忙")] 系统繁忙 = -1,

        /// <summary>
        /// 请求成功
        /// 说明：接口调用成功
        /// </summary>
        [Description("请求成功")] 请求成功 = 0,

        /// <summary>
        /// 请求不合法，包体格式错误
        /// 说明：HTTP_BAD_REQUEST
        /// </summary>
        [Description("请求不合法，包体格式错误")] 请求不合法_包体格式错误 = 400,

        /// <summary>
        /// 权限验证失败
        /// 说明：HTTP_UNAUTHORIZED
        /// </summary>
        [Description("权限验证失败")] 权限验证失败 = 401,

        /// <summary>
        /// 鉴权信息不合法，禁止访问
        /// 说明：HTTP_FORBIDDEN
        /// </summary>
        [Description("鉴权信息不合法，禁止访问")] 鉴权信息不合法_禁止访问 = 403,

        /// <summary>
        /// 请求失败
        /// 说明：HTTP_NOTFOUND
        /// </summary>
        [Description("请求失败")] 请求失败 = 404,

        /// <summary>
        /// 请求没有指定ContentLength
        /// 说明：HTTP_REQ_NOLENGTH
        /// </summary>
        [Description("请求没有指定ContentLength")] 请求没有指定ContentLength = 411,

        /// <summary>
        /// 请求包体太大
        /// 说明：HTTP_REQUEST_LARGE
        /// </summary>
        [Description("请求包体太大")] 请求包体太大_HTTP_REQUEST_LARGE = 413,

        /// <summary>
        /// 请求的服务没有找到
        /// 说明：HTTP_SERVER_NOTFOUND
        /// </summary>
        [Description("请求的服务没有找到")] 请求的服务没有找到 = 423,

        /// <summary>
        /// 请求的方法没有找到
        /// 说明：HTTP_METHOD_NOTFOUND
        /// </summary>
        [Description("请求的方法没有找到")] 请求的方法没有找到 = 424,

        /// <summary>
        /// 请求包体太大
        /// 说明：HTTP_REQUEST_OVERFLOW
        /// </summary>
        [Description("请求包体太大")] 请求包体太大_HTTP_REQUEST_OVERFLOW = 425,

        /// <summary>
        /// 请求超过频率限制
        /// 说明：HTTP_TOO_MANY_REQUEST
        /// </summary>
        [Description("请求超过频率限制")] 请求超过频率限制 = 429,

        /// <summary>
        /// 服务内部错误
        /// 说明：HTTP_INTERNAL_SERVER_ERROR
        /// </summary>
        [Description("服务内部错误")] 服务内部错误_SERVER_ERROR = 500,

        /// <summary>
        /// 网关错误，计算后台服务不可用
        /// 说明：HTTP_BAD_GETWAT
        /// </summary>
        [Description("网关错误，计算后台服务不可用")] 网关错误_计算后台服务不可用 = 502,

        /// <summary>
        /// 服务不可用
        /// 说明：HTTP_SERVICE_UNAVAILABLE
        /// </summary>
        [Description("服务不可用")] 服务不可用 = 503,

        /// <summary>
        /// 后端服务超时
        /// 说明：HTTP_GATEWAY_TIME_OUT
        /// </summary>
        [Description("后端服务超时")] 后端服务超时 = 504,

        /// <summary>
        /// 相似度错误
        /// 说明：SDK_DISTANCE_ERROR
        /// </summary>
        [Description("相似度错误")] 相似度错误 = -1100,

        /// <summary>
        /// 人脸检测失败
        /// 说明：SDK_IMAGE_FACEDETECT_FAILED
        /// </summary>
        [Description("人脸检测失败")] 人脸检测失败 = -1101,

        /// <summary>
        /// 图片解码失败
        /// 说明：SDK_IMAGE_DECODE_FAILED
        /// </summary>
        [Description("图片解码失败")] 图片解码失败 = -1102,

        /// <summary>
        /// 特征处理失败
        /// 说明：SDK_FEAT_PROCESSFAILED
        /// </summary>
        [Description("特征处理失败")] 特征处理失败 = -1103,

        /// <summary>
        /// 提取轮廓错误
        /// 说明：SDK_FACE_SHAPE_FAILED
        /// </summary>
        [Description("提取轮廓错误")] 提取轮廓错误 = -1104,

        /// <summary>
        /// 提取性别错误
        /// 说明：SDK_FACE_GENDER_FAILED
        /// </summary>
        [Description("提取性别错误")] 提取性别错误 = -1105,

        /// <summary>
        /// 提取表情错误
        /// 说明：SDK_FACE_EXPRESSION_FAILED
        /// </summary>
        [Description("提取表情错误")] 提取表情错误 = -1106,

        /// <summary>
        /// 提取年龄错误
        /// 说明：SDK_FACE_AGE_FAILED
        /// </summary>
        [Description("提取年龄错误")] 提取年龄错误 = -1107,

        /// <summary>
        /// 提取姿态错误
        /// 说明：SDK_FACE_POSE_FAILED
        /// </summary>
        [Description("提取姿态错误")] 提取姿态错误 = -1108,

        /// <summary>
        /// 提取眼镜错误
        /// 说明：SDK_FACE_GLASS_FAILED
        /// </summary>
        [Description("提取眼镜错误")] 提取眼镜错误 = -1109,

        /// <summary>
        /// 提取魅力值错误
        /// 说明：SDK_FACE_BEAUTY_FAILED
        /// </summary>
        [Description("提取魅力值错误")] 提取魅力值错误 = -1110,

        /// <summary>
        /// 语音合成失败
        /// 说明：TTS_PROCESS_FAILED
        /// </summary>
        [Description("语音合成失败")] 语音合成失败 = -1001,

        /// <summary>
        /// 存储错误
        /// 说明：STORAGE_ERROR
        /// </summary>
        [Description("存储错误")] 存储错误 = -1200,

        /// <summary>
        /// 缓存错误
        /// 说明：CACHE_ERROR
        /// </summary>
        [Description("缓存错误")] 缓存错误 = -1201,

        /// <summary>
        /// 图片为空
        /// 说明：ERROR_IMAGE_EMPTY
        /// </summary>
        [Description("图片为空")] 图片为空 = -1300,

        /// <summary>
        /// 参数为空
        /// 说明：ERROR_PARAMETER_EMPTY
        /// </summary>
        [Description("参数为空")] 参数为空 = -1301,

        /// <summary>
        /// 个体已存在
        /// 说明：ERROR_PERSON_EXISTED
        /// </summary>
        [Description("个体已存在")] 个体已存在 = -1302,

        /// <summary>
        /// 个体不存在
        /// 说明：ERROR_PERSON_NOT_EXISTED
        /// </summary>
        [Description("个体不存在")] 个体不存在 = -1303,

        /// <summary>
        /// 参数过长
        /// 说明：ERROR_PARAMETER_TOO_LONG
        /// </summary>
        [Description("参数过长")] 参数过长 = -1304,

        /// <summary>
        /// 人脸不存在
        /// 说明：ERROR_FACE_NOT_EXISTED
        /// </summary>
        [Description("人脸不存在")] 人脸不存在 = -1305,

        /// <summary>
        /// 组不存在
        /// 说明：ERROR_GROUP_NOT_EXISTED
        /// </summary>
        [Description("组不存在")] 组不存在 = -1306,

        /// <summary>
        /// 组列表不存在
        /// 说明：ERROR_GROUPLIST_NOT_EXISTED
        /// </summary>
        [Description("组列表不存在")] 组列表不存在 = -1307,

        /// <summary>
        /// url图片下载失败
        /// 说明：ERROR_DOWNLOAD_IMAGE_FAILED
        /// </summary>
        [Description("url图片下载失败")] url图片下载失败 = -1308,

        /// <summary>
        /// 人脸个数超过限制
        /// 说明：ERROR_FACE_NUM_EXCEED
        /// </summary>
        [Description("人脸个数超过限制")] 人脸个数超过限制 = -1309,

        /// <summary>
        /// 个体个数超过限制
        /// 说明：ERROR_PERSON_NUM_EXCEED
        /// </summary>
        [Description("个体个数超过限制")] 个体个数超过限制 = -1310,

        /// <summary>
        /// 组个数超过限制
        /// 说明：ERROR_GROUP_NUM_EXCEED
        /// </summary>
        [Description("组个数超过限制")] 组个数超过限制 = -1311,

        /// <summary>
        /// 对个体添加了几乎相同的人脸
        /// 说明：ERROR_SAME_FACE_ADDED
        /// </summary>
        [Description("对个体添加了几乎相同的人脸")] 对个体添加了几乎相同的人脸 = -1312,

        /// <summary>
        /// 参数不合法（特殊字符比如空格、斜线、tab、换行符）
        /// 说明：ERROR_PARAMETER_INVALID
        /// </summary>
        [Description("参数不合法（特殊字符比如空格、斜线、tab、换行符）")] 参数不合法_特殊字符比如空格_斜线_tab_换行符 = -1313,

        /// <summary>
        /// 无效的图片格式
        /// 说明：ERROR_IMAGE_FORMAT_INVALID
        /// </summary>
        [Description("无效的图片格式")] 无效的图片格式 = -1400,

        /// <summary>
        /// 图片模糊度检测失败
        /// 说明：ERROR_IMAGE_FUZZY_DETECT_FAILED
        /// </summary>
        [Description("图片模糊度检测失败")] 图片模糊度检测失败 = -1401,

        /// <summary>
        /// 美食图片检测失败
        /// 说明：ERROR_IMAGE_FOOD_DETECT_FAILED
        /// </summary>
        [Description("美食图片检测失败")] 美食图片检测失败 = -1402,

        /// <summary>
        /// 图片下载失败
        /// 说明：ERROR_IMAGE_DOWNLOAD_FAILED
        /// </summary>
        [Description("图片下载失败")] 图片下载失败 = -1403,

        /// <summary>
        /// 算法模型调用错误
        /// 说明：ERROR_IMAGE_CLASSIFY_FAILED
        /// </summary>
        [Description("算法模型调用错误")] 算法模型调用错误 = -1404,

        /// <summary>
        /// 提取图像指纹失败
        /// 说明：ERROR_IMAGE_FINGERPRINT_FAILED
        /// </summary>
        [Description("提取图像指纹失败")] 提取图像指纹失败 = -1405,

        /// <summary>
        /// 图像特征比对失败
        /// 说明：ERROR_IMAGE_COMPARE_FAILED
        /// </summary>
        [Description("图像特征比对失败")] 图像特征比对失败 = -1406,

        /// <summary>
        /// 图片超出下载限制
        /// 说明：ERROR_DOWNLOAD_IMAGE_SIZE_EXCEED
        /// </summary>
        [Description("图片超出下载限制")] 图片超出下载限制 = -1408,

        /// <summary>
        /// 图片不满足检测要求
        /// 说明：ERROR_IMAGE_UNSATISFACTORY
        /// </summary>
        [Description("图片不满足检测要求")] 图片不满足检测要求 = -1409,

        /// <summary>
        /// 图像请求URL的格式错误
        /// 说明：ERROR_IVADLID_URL_FROMAT
        /// </summary>
        [Description("图像请求URL的格式错误")] 图像请求URL的格式错误 = -1505,

        /// <summary>
        /// 图像下载超时
        /// 说明：ERROR_DOWNLOAD_TIMEOUT
        /// </summary>
        [Description("图像下载超时")] 图像下载超时 = -1506,

        /// <summary>
        /// 无法连接图像下载服务器
        /// 说明：ERROR_CONNECT_DOWNLOAD_SERVER
        /// </summary>
        [Description("无法连接图像下载服务器")] 无法连接图像下载服务器 = -1507,

        /// <summary>
        /// 文本为空
        /// 说明：TEXT_EMPTY
        /// </summary>
        [Description("文本为空")] 文本为空 = -2000,

        /// <summary>
        /// 文本过长
        /// 说明：TEXT_TOO_LONG
        /// </summary>
        [Description("文本过长")] 文本过长 = -2001,

        /// <summary>
        /// OCR照片为空
        /// 说明：OCR_BUF_EMPTY
        /// </summary>
        [Description("OCR照片为空")] OCR照片为空 = -5101,

        /// <summary>
        /// OCR识别失败
        /// 说明：OCR_RECOG_FAILED
        /// </summary>
        [Description("OCR识别失败")] OCR识别失败 = -5103,

        /// <summary>
        /// 身份证边框不完整
        /// 说明：OCR_CORNER_INCOMPLETE
        /// </summary>
        [Description("身份证边框不完整")] 身份证边框不完整 = -5106,

        /// <summary>
        /// 输入图片不是身份证
        /// 说明：OCR_NOT_IDCARD
        /// </summary>
        [Description("输入图片不是身份证")] 输入图片不是身份证 = -5107,

        /// <summary>
        /// 身份证信息不合规范
        /// 说明：OCR_IDCARD_ILLEGAL
        /// </summary>
        [Description("身份证信息不合规范")] 身份证信息不合规范 = -5108,

        /// <summary>
        /// 照片模糊
        /// 说明：OCR_IMAGE_BLUR
        /// </summary>
        [Description("照片模糊")] 照片模糊 = -5109,

        /// <summary>
        /// 名片无足够文本
        /// 说明：OCR_NOT_ENOUGH_TEXTLINES
        /// </summary>
        [Description("名片无足够文本")] 名片无足够文本 = -5201,

        /// <summary>
        /// 名片文本行倾斜角度太大
        /// 说明：OCR_TEXTLINES_SKEWED
        /// </summary>
        [Description("名片文本行倾斜角度太大")] 名片文本行倾斜角度太大 = -5202,

        /// <summary>
        /// 名片模糊
        /// 说明：OCR_TEXTLINES_FUZZY
        /// </summary>
        [Description("名片模糊")] 名片模糊 = -5203,

        /// <summary>
        /// 名片姓名识别失败
        /// 说明：OCR_UNRECOG_NAME
        /// </summary>
        [Description("名片姓名识别失败")] 名片姓名识别失败 = -5204,

        /// <summary>
        /// 名片电话识别失败
        /// 说明：OCR_UNRECOG_TEL
        /// </summary>
        [Description("名片电话识别失败")] 名片电话识别失败 = -5205,

        /// <summary>
        /// 图像为非名片图像
        /// 说明：OCR_NOT_A_NAMECARD
        /// </summary>
        [Description("图像为非名片图像")] 图像为非名片图像 = -5206,

        /// <summary>
        /// 检测或者识别失败
        /// 说明：DETECT_AND_RECONG_FAILED
        /// </summary>
        [Description("检测或者识别失败")] 检测或者识别失败 = -5207,

        /// <summary>
        /// 服务内部错误
        /// 说明：OCR_SERVER_INTERN_ERROR
        /// </summary>
        [Description("服务内部错误")] 服务内部错误 = -5208,

        /// <summary>
        /// 未检测到身份证，请对准边框(请避免拍摄时倾角和旋转角过大、摄像头)
        /// 说明：NOT_CARD
        /// </summary>
        [Description("未检测到身份证，请对准边框(请避免拍摄时倾角和旋转角过大、摄像头)")] 未检测到身份证_请对准边框_请避免拍摄时倾角和旋转角过大_摄像头 = -7001,

        /// <summary>
        /// 请使用第二代身份证件进行扫描
        /// 说明：NOT_SECOND_IDCARD
        /// </summary>
        [Description("请使用第二代身份证件进行扫描")] 请使用第二代身份证件进行扫描 = -7002,

        /// <summary>
        /// 不是身份证正面照片(请使用带证件照的一面进行扫描)
        /// 说明：NOT_FRONT_IDCARD
        /// </summary>
        [Description("不是身份证正面照片(请使用带证件照的一面进行扫描)")] 不是身份证正面照片_请使用带证件照的一面进行扫描 = -7003,

        /// <summary>
        /// 不是身份证反面照片(请使用身份证反面进行扫描)
        /// 说明：NOT_BACK_IDCARD
        /// </summary>
        [Description("不是身份证反面照片(请使用身份证反面进行扫描)")] 不是身份证反面照片_请使用身份证反面进行扫描 = -7004,

        /// <summary>
        /// 确保扫描证件图像清晰
        /// 说明：IDCARD_FUZZY
        /// </summary>
        [Description("确保扫描证件图像清晰")] 确保扫描证件图像清晰 = -7005,

        /// <summary>
        /// 请避开灯光直射在证件表面
        /// 说明：IDCARD_LIGHT_NOT_BLANCE
        /// </summary>
        [Description("请避开灯光直射在证件表面")] 请避开灯光直射在证件表面 = -7006,

        /// <summary>
        /// 请求type错误，不是0，1
        /// 说明：DLOCR_WRONG_TYPE_INPUT
        /// </summary>
        [Description("请求type错误，不是0，1")] 请求type错误_不是0_1 = -9001,

        /// <summary>
        /// OCR识别失败
        /// 说明：DLOCR_RECONG_FAILED
        /// </summary>
        [Description("OCR识别失败")] OCR识别失败_DLOCR_RECONG_FAILED = -9002,

        /// <summary>
        /// OCR识别失败
        /// 说明：GLOCR_RECONG_FAILED
        /// </summary>
        [Description("OCR识别失败")] OCR识别失败_GLOCR_RECONG_FAILED = -9003,

        /// <summary>
        /// 银行卡OCR预处理错误
        /// 说明：CREDITCARD_OCR_PREPROCESS_ERROR
        /// </summary>
        [Description("银行卡OCR预处理错误")] 银行卡OCR预处理错误 = -9010,

        /// <summary>
        /// 银行卡OCR识别失败
        /// 说明：CREDITCARD_OCR_RECOG_FAILED
        /// </summary>
        [Description("银行卡OCR识别失败")] 银行卡OCR识别失败 = -9011,

        /// <summary>
        /// 银行卡图片模糊
        /// 说明：CREDITCARD_OCR_IMAGE_BLUR
        /// </summary>
        [Description("银行卡图片模糊")] 银行卡图片模糊 = -9012,

        /// <summary>
        /// 不是银行卡
        /// 说明：ERROR_NOT_A_CREDITCARD
        /// </summary>
        [Description("不是银行卡")] 不是银行卡 = -9013,

        /// <summary>
        /// 卡号为空或不符合规范
        /// 说明：ERROR_CREDITCARD_ILLEGAL
        /// </summary>
        [Description("卡号为空或不符合规范")] 卡号为空或不符合规范 = -9014,

        /// <summary>
        /// 营业执照OCR
        /// 说明：BIZLICENSE_OCR_PREPROCESS_FAILED
        /// </summary>
        [Description("营业执照OCR")] 营业执照OCR_BIZLICENSE_OCR_PREPROCESS_FAILED = -9501,

        /// <summary>
        /// 营业执照OCR
        /// 说明：BIZLICENSE_OCR_RECOG_FAILED
        /// </summary>
        [Description("营业执照OCR")] 营业执照OCR_BIZLICENSE_OCR_RECOG_FAILED = -9502,

        /// <summary>
        /// 车牌OCR预处理错误
        /// 说明：PLATE_OCR_PREPROCESS_ERROR
        /// </summary>
        [Description("车牌OCR预处理错误")] 车牌OCR预处理错误 = -9701,

        /// <summary>
        /// 车牌OCR识别失败
        /// 说明：PLATE_OCR_RECOG_FAILED
        /// </summary>
        [Description("车牌OCR识别失败")] 车牌OCR识别失败 = -9702,

    }
}
