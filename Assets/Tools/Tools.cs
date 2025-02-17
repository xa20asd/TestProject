using UnityEngine;

namespace honordes.tools
{
    public class Tools
    {
        /// <summary>
        /// 輸出訊息並指定顏色
        /// </summary>
        /// <param name="message">訊息</param>
        /// <param name="color">顏色</param>
        /// <returns>包含顏色的訊息</returns>
        public static string LogMessage(string message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }

        /// <summary>
        /// 輸出訊息並指定顏色
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string LogMessage(object message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }

    }

}

