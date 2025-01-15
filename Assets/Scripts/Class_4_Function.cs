using UnityEngine;


/// <summary>
/// 方法
/// 中文:方法、函式、函數、功能
/// 英文: function、method (Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    private void Awake()
    {
        //呼叫方法，若沒有呼叫不會執行
        //方法名稱();
        FirstFunction();
        SecondFunction();
        //呼叫有參數的方法: 小括號內要放入引數
        //Useskill(); 錯誤:少了引數
        Useskill("魔天一擊");
        Useskill("劍氣縱橫");
    }
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
    private void Useskill(string skill)
    {
        Debug.Log($"<color=aqua>施放技能:{skill}</color>");
    }
}
