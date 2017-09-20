using System;
using System.Security.Cryptography;
using System.Text;

namespace WeixinSDK.Work.Common
{
    /// <summary>
    /// 签名加密类
    /// </summary>
    internal class EncryptHelper
    {
        /// <summary>
        /// 获取大写的MD5签名结果
        /// </summary>
        /// <param name="encypStr">需要加密的字符串</param>
        /// <param name="encoding">编码</param>
        /// <returns></returns>
        public static string GetMD5(string encypStr, Encoding encoding)
        {
            string retStr;
            MD5CryptoServiceProvider m5 = new MD5CryptoServiceProvider();

            //创建md5对象
            byte[] inputBye;
            byte[] outputBye;

            //使用指定编码方式把字符串转化为字节数组．
            try
            {
                inputBye = encoding.GetBytes(encypStr);
            }
            catch (Exception ex)
            {
                inputBye = Encoding.GetEncoding("utf-8").GetBytes(encypStr);
            }
            outputBye = m5.ComputeHash(inputBye);

            retStr = BitConverter.ToString(outputBye);
            retStr = retStr.Replace("-", "").ToUpper();
            return retStr;
        }

        /// <summary>
        /// 签名算法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetSha1(string str)
        {
            //建立SHA1对象
            SHA1 sha = new SHA1CryptoServiceProvider();
            //将mystr转换成byte[] 
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] dataToHash = enc.GetBytes(str);
            //Hash运算
            byte[] dataHashed = sha.ComputeHash(dataToHash);
            //将运算结果转换成string
            string hash = BitConverter.ToString(dataHashed).Replace("-", "");
            return hash;
        }
    }
}
