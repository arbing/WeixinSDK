using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentSDK.YoutuYun.Models.Common;

namespace TencentSDK.YoutuYun.Models.Ocr
{
    /// <summary>
    /// 通用OCR识别的返回结果类
    /// </summary>
    public class GeneralOcrResult : JsonResult
    {
        /// <summary>
        /// 识别出的所有字段信息每个字段包括，item, itemcoord, words
        /// </summary>
        public List<GeneralOcrItemInfo> items { get; set; }

        /// <summary>
        /// 保留字段，目前不使用
        /// </summary>
        public string session_id { get; set; }
    }

    /// <summary>
    /// 识别出的所有字段信息每个字段包括，item, itemcoord, words
    /// </summary>
    public class GeneralOcrItemInfo
    {
        /// <summary>
        /// 字段字符串
        /// </summary>
        public string itemstring { get; set; }

        /// <summary>
        /// 字段在图像中的像素坐标，包括左上角坐标x,y，以及宽、高width, height
        /// </summary>
        public CoordInfo itemcoord { get; set; }

        /// <summary>
        /// 字段识别出来的每个字的信息，包括具体的字character，以及字对应的置信度confidence
        /// </summary>
        public List<WordInfo> words { get; set; }
    }

    /// <summary>
    /// 字段在图像中的像素坐标，包括左上角坐标x,y，以及宽、高width, height
    /// </summary>
    public class CoordInfo
    {
        /// <summary>
        /// 左上角坐标x
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// 左上角坐标y
        /// </summary>
        public int y { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        public int height { get; set; }
    }

    /// <summary>
    /// 字段识别出来的每个字的信息，包括具体的字character，以及字对应的置信度confidence
    /// </summary>
    public class WordInfo
    {
        /// <summary>
        /// 识别出的单字字符
        /// </summary>
        public string character { get; set; }

        /// <summary>
        /// 识别出的单字字符对应的置信度
        /// </summary>
        public double confidence { get; set; }

    }
}
