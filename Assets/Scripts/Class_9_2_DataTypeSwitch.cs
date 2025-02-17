using honordes.tools;
using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class Class_9_2_DataTypeSwitch : MonoBehaviour
    {
        private void Awake()
        {
            //隱式轉換: 不需要另外宣告轉換類型
            //將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;

            Tools.LogMessage(byte1, "yellow");
            Tools.LogMessage(byte1.GetType(), "yellow");
            Tools.LogMessage(int1, "yellow");
            Tools.LogMessage(int1.GetType(), "yellow");

            //隱式轉換: 將比較小的byte放到大的int
            int1 = byte1;
            Tools.LogMessage(int1, "yellow");
            Tools.LogMessage(int1.GetType(), "yellow");

            //顯示轉換: 需要宣告轉換類型
            //將小的資料放到大的資料內
            int int2 = 100;
            byte byte2 = 0;
            Tools.LogMessage(byte2, "aqua");
            Tools.LogMessage(byte2.GetType(), "aqua");
            Tools.LogMessage(int2, "aqua");
            Tools.LogMessage(int2.GetType(), "aqua");

            //顯示轉換: 將比較大的int放到小的byte
            //添加(資料類型)
            byte2 = (byte)int2;
            Tools.LogMessage(byte2, "aqua");
            Tools.LogMessage(byte2.GetType(), "aqua");

            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            Tools.LogMessage(byte3, "green");

            //範圍較大的轉為範圍較小的，會發生"溢位"
            int int3 = 256;
            byte byte4 = 0;
            byte4 = (byte)int3;
            Tools.LogMessage(byte4, "red");


        }
    }

}
