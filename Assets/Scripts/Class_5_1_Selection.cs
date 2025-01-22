using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//命名空間
//將類別分類，類似倉庫的概念，不同倉庫可以有相同名稱類別
//語法: namespace 命名空間名稱 {內容}
namespace honordes
{
    /// <summary>
    /// 選取陳述式 Selection Statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour
    {

        [SerializeField, Header("是否開門")]
        private bool isOpen;

        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;

        [SerializeField, Header("武器")]
        private string weapon;

        private void Awake()
        {
            // if 判斷式
            // if (布林值)
            if (true)
            {
                Debug.Log("當boolean為True");
            }
            //快速完成: 輸入if 選取
            if (false)
            {
                Debug.Log("當boolean為false");
            }
        }

        //更新事件: 一秒鐘執行約60次( 60FPS) Frame per Second
        private void Update()
        {
            //常用快捷鍵
            //1.格式化  ctrl + K D
            //2. 程式碼片段 ctrl + K S  選region
            #region 判斷式if
            Debug.Log("<color=red>更新事件</color>");

            //如果isOpen等於 True，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=green>已經開門</color>");
            }

            //否則isOpen等於false，就顯示門關了
            else
            {
                Debug.Log("<color=green>門關了</color>");
            }

            //比較運算子，邏輯運算子結果為boolean
            // 分數>= 60 通過
            if (score >= 60)
            {
                Debug.Log("<color=orange>恭喜C#通過了</color>");
            }
            // 分數>= 40 有補考機會
            else if (score >= 40)
            {
                Debug.Log("<color=orange>你可以補考的</color>");
            }
            // 分數>= 20 有補考機會，但要額外做個小專題來補分
            else if (score >= 20)
            {
                Debug.Log("<color=orange>你可以補考的，但要額外做小專題來補分</color>");
            }
            //否則，被當掉
            else
            {
                Debug.Log("<color=orange>很可惜C#被當了</color>");
            }
            #endregion

            #region 判斷式switch
            //switch 判斷式
            //switch (要判斷的值) {陳述式}
            switch (weapon)
            {
                //case 值:
                //當判斷的值等於值時會執行這裡
                //break;  跳出判斷式
                case "小刀":
                    //武器等於小刀，顯示攻擊力為20
                    Debug.Log("<color=purple>攻擊力: 20</color>");
                    break;
                //武器等於大刀，顯示攻擊力為35
                case "大刀":
                    Debug.Log("<color=purple>攻擊力: 35</color>");
                    break;
                //武器等於鈍刀，顯示攻擊力為25
                case "鈍刀":
                    Debug.Log("<color=purple>攻擊力: 25</color>");
                    break;

                // 當weapon 的值不等於上面的所有值則會執行下列程式碼
                default:
                    Debug.Log("<color=purple>無攻擊力</color>");
                    break;
            } 
            #endregion
        }



    }
}
