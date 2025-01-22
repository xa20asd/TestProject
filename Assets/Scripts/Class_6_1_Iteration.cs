using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 反覆運算陳述式: 迴圈
    /// for、foreach、do and while
    /// </summary>
    public class Class_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {

            #region while迴圈
            //迴圈請在一次事件內使用Awake、Start
            //while 迴圈: 當布林值為true時會持續執行
            //while (布林值) {程式區塊}
            //無限迴圈:布林值一直是true

            int i = 0;
            while (i < 5)
            {
                Debug.Log($"<color=orange>while 迴圈, i = {i}</color>");
                i++;
            }
            #endregion

            #region dowhile迴圈
            // do 迴圈
            // do {程式區塊} while (布林值)
            int j = 0;
            do
            {
                Debug.Log($"<color=yellow>do 迴圈, j = {j}</color>");
                j++;
            }
            while (j < 5);
            #endregion

            #region for迴圈
            //for 迴圈
            //for (初始值;布林值;迭代器) {程式區塊}
            for (int k = 0; k < 5; k++)
            {
                Debug.Log($"<color=green>for 迴圈, k = {k}</color>");
            }
            #endregion

            // foreach 迴圈
            // 資料結構:陣列、清單等等...
            // foreach (資料類型 資料名稱 in 資料結構) {程式區塊}
            // 字串就是一種資料結構，用來存放 char 的陣列
            string dialogue = "你好，我是路人甲NPC";
            // foreach 迴圈將抓出dialogue的每一個字並存放在區域變數text內
            // var 無類型
            foreach (var text in dialogue)
            { 
                Debug.Log ($"<color=aqua>{text}</color>");
            }


        }
    }
}
