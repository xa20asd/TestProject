using System;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 課程3 :運算子
/// 補充: Unity 欄位屬性、Unity事件
/// </summary>
public class Class_3_Operator : MonoBehaviour
{
    #region  基本欄位屬性
    //欄位屬性 Field Attribute
    [Header("等級")]
    // C# 變數 = 欄位 Field
    public int lv = 1;

    //[提示(提示文字)] : 在屬性面板滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度，不建議超過100")]
    public float moveSpeed = 2.5f;

    //[範圍(最小,最大)]: 幫數值類型添加範圍(面版上為滑桿式)
    [Range(1, 99)]
    public byte count = 10;

    //[Range] 不能用在非數值類型上，會顯示"Use Range With..."
    [Range(10, 99)]
    public string weapon = "刀";

    //[文字範圍(最小行, 最大行)]: 使用在字串上，設定面板上的文字框範圍
    [TextArea(2, 7)]
    public string itemDescription = "這把刀上有毒喔!  我舔...";


    //多個欄位屬性
    [Header("血量")][Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力")]
    [Range(0, 50)]
    public float attack = 30.5f;

    //[在屬性面板隱藏] :將公開變數隱藏
    [HideInInspector]
    public string password = "我是密碼";

    //[序列化]: 將私人變數顯示
    [SerializeField]
    private float mp = 500;
    #endregion

    //使用 Unity的事件
    // 1.必須在腳本後面添加 : MonoBehaviour(繼承)
    // 2.使用關鍵字快速完成， ex 輸入awake挑選要使用的事件按Enter
    // 喚醒文件: 播放遊戲後會執行的第一個事件，只執行一次
    // 事件名稱是藍色的 (沒有變色不影響)
    private void Awake()
    {
        #region 輸出訊息
        // 將小括號內的訊息輸出到 Unity 的 Console 控制台面板
        // Ctrl + Shift + C 開啟控制台面板
        Debug.Log("Hello  臥得");
        Debug.Log(hp);
        Debug.Log("犧牲HP" + hp + "點" + ", 增加Attack" + attack + "點");
        Debug.Log("攻擊力:" + attack); //字串與變數
        Debug.Log($"攻擊力: {attack}"); //$字串變數
        Debug.Log("攻擊力: {attack}"); // 沒有$

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=orange>橘色</color>");
        Debug.Log("<color=#66aaff>藍色</color>");
        #endregion

        #region 算數運算子
        //運算子
        // 1.算數運算子

        Debug.Log("<color=orange>---算數運算子---</color>");
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);
        Debug.Log(10 % 3);

        Debug.Log("<color=#66aaff>---算數運算子:區域變數---</color>");
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);
        Debug.Log(numberA % numberB);
        #endregion

        #region 比較運算子
        Debug.Log("<color=orange>---比較運算子---</color>");
        //比較運算子，使用後會得到boolean值
        int numberC = 100, numberD = 999;

        Debug.Log(numberC > numberD);
        Debug.Log(numberC >= numberD);
        Debug.Log(numberC < numberD);
        Debug.Log(numberC <= numberD);
        Debug.Log(numberC == numberD);
        Debug.Log(numberC != numberD);
        #endregion

        #region 布林值邏輯運算子
        Debug.Log("<color=red>---布林值邏輯運算子---</color>");
        //邏輯否定:將布林值變成相反的值
        Debug.Log(!true);
        Debug.Log(!false);
        bool boolVarTrue = true, boolVarFalse = false;
        Debug.Log(!boolVarTrue);
        Debug.Log(!boolVarFalse);

        Debug.Log("<color=green>---&& ||---</color>");
        // && 比較2個boolean，只要有一個false就是false
        Debug.Log(true && true);
        Debug.Log(true && false);
        Debug.Log(false && true);
        Debug.Log(false && false);
        // || 比較2個boolean，只要有一個true就是true
        Debug.Log(true || true);
        Debug.Log(true || false);
        Debug.Log(false || true);
        Debug.Log(false || false);
        #endregion

    }
}
