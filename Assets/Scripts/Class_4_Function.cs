using UnityEngine;
using static UnityEditor.Progress;


/// <summary>
/// 方法
/// 中文:方法、函式、函數、功能
/// 英文: function、method (Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    private void Awake()
    {
        #region 方法基本語法與參數呼叫
        //呼叫方法，若沒有呼叫不會執行
        //方法名稱();
        FirstFunction();
        SecondFunction();
        //呼叫有參數的方法: 小括號內要放入引數
        //Useskill(); 錯誤:少了引數
        Useskill("魔天一擊", 88);
        Useskill("劍氣縱橫", 50);
        //呼叫有預設值參數的方法: 可以不用填(選項是參數)
        SpawnEnemy();
        SpawnEnemy("菇菇寶貝");

        Fire(1000);
        Fire(9999, "十字文槍");

        //有多個選擇性參數時的呼叫
        BuyItem();
        BuyItem(count: 30);
        BuyItem(item: "白水");
        BuyItem(item: "白水", count: 50);
        #endregion

        //呼叫有傳回方法
        //第一種: 把結果放到區域變數內
        //int number9 = Square(9);
        //Debug.Log($"<color=green>9的平方 {number9}</color>");
        //第二種:把傳回方法當作該傳回類型使用
        Debug.Log($"<color=green>7的平方 {Square(7)}</color>");

        Debug.Log($"<color=blue>{BMI(60, 1.68f)}</color>");
        Debug.Log($"<color=blue>{BMI(69, 1.80f)}</color>");

        Move();
        Move(50.5f);
    }

    // 框選欲整理的程式段，  Ctrl + K S  #region 快速完成程式碼片段
    #region 方法基本語法與參數
    //方法
    //包含一系列程式區塊
    //方法語系:
    //修飾詞 傳回資料類型 方法名稱() {程式區塊}
    //方法命名習慣: Unity 習慣使用大寫開頭命名方法
    // void 無傳回: 使用此方法不會傳回資料
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }
    private void SecondFunction()
    {
        Debug.Log("第二個方法");
    }
    // 參數語法: 與區域變數相同 資料類型 參數名稱 (習慣用小寫或加底線開頭)
    private void Useskill(string skill, float cost)
    {
        Debug.Log($"<color=aqua>施放技能:{skill}</color>");
        Debug.Log($"<color=yellow>技能消耗:{cost}</color>");
    }
    private void SpawnEnemy(string enemy = "巴洛古")
    {
        Debug.Log($"<color=orange>生成敵人:{enemy}</color>");
    }

    //沒有預設值稱為「必要參數」，有預設值稱為選擇性參數
    //選擇性參數要寫在右邊
    //private void Fire(, string fire = "子彈", int speed)
    //{
    //    Debug.Log($"<color=ligntorange>發射物件:{fire},速度:{speed}</color>");
    //}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="fire"></param>

    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=green>發射物件:{fire},速度:{speed}</color>");
    }

    private void BuyItem(string item = "超級藥水", int count = 100)
    {
        Debug.Log($"<color=aqua>購買商品:{item},購買數量:{count}</color>");
    } 
    #endregion

    //傳回方法: 傳回類型不是void，呼叫該方法會獲得結果
    //傳回方法必須在{}內使用return關鍵字將結果傳回
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    
    private float Square(float number)
    {
        return number * number;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="weight"></param>
    /// <param name="hh"></param>
    /// <returns></returns>
    private float BMI(float weight, float hh)
    {
        return weight / Square(hh);
    }

    
    //名稱不能重複，類別、變數與方法
    private void Test() { }
    //private void Test() { } 名稱重複的錯誤

    //方法多載 function overload
    //參數的類性或數量不同
    //0個參數

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Debug.Log($"<color=aqua>移動中</color>");
    }

    /// <summary>
    /// 移動方法並指定速度
    /// </summary>
    /// <param name="speed">移動速度</param>
    private void Move(float speed)
    {
        Debug.Log($"<color=aqua>移動中，速度:{speed}</color>");
    }
}
