using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 陣列
    /// </summary>
    public class Class_6_2_Array : MonoBehaviour
    {
        //不使用陣列的寫法:
        //皮卡丘、小火龍、卡比獸
        public string card1 = "皮卡丘", card2 = "小火龍", card3 = "卡比獸";

        //使用陣列的寫法
        //陣列: 用來儲存多筆相同類型的資料
        //第一種:不指定值，透過Unity面板輸入
        //修飾詞 資料類型[] 陣列名稱;
        public string[] cards;
        //第二種:直接定義陣列的數量
        //定義一個牌組1，可以放5張卡牌
        public string[] deck1 = new string[5];
        //第三種:直接定義陣列的值
        public string[] deck2 = {"路奇亞","小遙","火雉雞"};

        //二維陣列
        public string[,] inventory = { { "紅水", "藍水" }, { "炸彈", "金幣" } };
        //三維陣列
        public string[,,] shop =
        {
            {{"傷藥","好傷藥" },{"PP噴霧","白金噴霧" } },
            {{"紅水","超水" },{"蘋果","檸檬" } }
        };
        private void Awake()
        {
            #region 一維陣列
            //存取陣列 Set、Get
            //Get 取得陣列的資料
            //陣列名稱{編號}
            Debug.Log($"<color=aqua>Cards的第3張卡牌:{cards[2]}</color>");
            //超出陣列範圍，會導致錯誤
            //錯誤會導致當機、閃退、不符合預期的結果或者不執行下方程式

            //Set 設定陣列的資料
            //陣列名稱[編號] 指定值;
            deck2[2] = "傑尼龜";
            Debug.Log($"<color=aqua>Deck2的第3張卡牌:{deck2[2]}</color>");
            #endregion

            #region 二維三維陣列
            //存取二維陣列
            Debug.Log($"<color=green>編號[0,1]的道具:{inventory[0, 1]}</color>");

            inventory[1, 1] = "寶箱";
            Debug.Log($"<color=green>編號[1,1]的道具:{inventory[1, 1]}</color>");


            //存取三維陣列
            Debug.Log($"<color=yellow>編號[0,1,1]的道具:{shop[0, 1, 1]}</color>");

            shop[1, 0, 1] = "全滿藥水";
            Debug.Log($"<color=yellow>編號[1,0,1]的道具:{shop[1, 0, 1]}</color>");
            #endregion

            //獲得陣列的長度或維度
            //一維~多維陣列的長度: 陣列名稱.Length
            Debug.Log($"<color=red>一維陣列長度:{deck2.Length}</color>");
            Debug.Log($"<color=red>二維陣列長度:{inventory.Length}</color>");
            Debug.Log($"<color=red>三維陣列長度:{shop.Length}</color>");

            //陣列的維度: 陣列名稱.Rank
            Debug.Log($"<color=red>一維陣列維度:{deck2.Rank}</color>");
            Debug.Log($"<color=red>二維陣列維度:{inventory.Rank}</color>");
            Debug.Log($"<color=red>三維陣列維度:{shop.Rank}</color>");
        }
    }
}
