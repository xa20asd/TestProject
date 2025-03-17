using System;
using JetBrains.Annotations;
using UnityEngine;

namespace honordes
{
    public class Class_17_Tuple : MonoBehaviour
    {
        private void Awake()
        {
            // 元組: 儲存多筆不同類型的資料
            // 宣告方式1 : 指定類型與名稱
            (string name, int cost, int index) card1 = ("史萊姆", 1, 7);
            Debug.Log($"{card1.name} | 消耗: {card1.cost}　| 編號: {card1.index}");

            // 宣告方式2: 指定類型
            (string, int, int) card2 = ("哥布林", 2, 2);
            Debug.Log($"{card2.Item1} | {card2.Item2} | {card2.Item3}");

            //宣告方式3: 使用var
            var card3 = ("樹精", 4, 50);
            Debug.Log($"{card3.Item1} | {card3.Item2} | {card3.Item3}");

            //宣告方式4: 使用var以及指名
            var card4 = (name: "人馬獸", cost: 2, index: 6);
            Debug.Log($"{card4.name} | 消耗: {card4.cost}　| 編號: {card4.index}");

            UseCard(card1);
            UseCard(card2);
            UseCard(("青眼究極龍", 7, 200));
        }

        /// <summary>
        /// 使用卡牌
        /// </summary>
        /// <param name="card">卡牌元組，名稱、消耗與編號</param>
        private void UseCard((string name, int cost, int index) card)
        {
            Debug.Log($"消耗{card.cost} 使用卡牌: {card.name}");
        }
    }
}
