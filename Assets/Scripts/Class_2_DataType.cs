using UnityEngine;

//  3/// 是摘要(xml)，用來簡要說明，可加在類別與變數上方
/// <summary>
/// 認識C# 資料類型
/// </summary>

public class Class_2_DataType : MonoBehaviour 
{
    //變數語法:
    //修飾詞 資料類型 變數名稱 指定 預設值;
    //四大常用資料類型
    //整數:儲存沒有小數點的數值 int
    //浮點數:儲存有小數點的數值 float
    //字串: 儲存文字，必須用"" string
    //布林值: 儲存正與反 bool 只有2種值 true & false
    public int count = 7;
    public float moveSpeed = 3.5f; //浮點數必須要加 f 後綴詞
    public float turnSpeed = 30.0F; //大小 F 皆可
    public string character = "Monster";
    public bool isDead = false;
    public bool gameOver = true;

    // 整數資料類型
    public byte lv = 16;   //byte 範圍 0~255 大小 8 byte
    public uint coin = 9999; // uint 範圍0~4***，大小 32byte
    public long items = 3000; // long 範圍 0~92***，大小 64byte

    //字串與字元
    public string playerName = "Honordes";  //字串: 儲存多個字元，使用""
    public char a = 'a';                    //字元: 儲存1個字元，使用''

    //溢位
    //public sbyte num = 128;   //溢位導致錯誤產生
}
