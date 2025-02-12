using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 類別練習
    /// </summary>
    public class 練習_8_類別 : MonoBehaviour
    {
        private void Awake()
        {
            //實例化2個BOSS
            練習_8_Boss Boss1 = new 練習_8_Boss("鎖刃龍", "甩出龍屬鎖鍊", 10000);
            練習_8_Boss Boss2 = new 練習_8_Boss("原初爵銀龍", "使出尾槍", 5000);

            Boss1.Bossinfo();
            Boss2.Bossinfo();
        }
    }
}
