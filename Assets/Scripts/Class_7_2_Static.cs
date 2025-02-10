using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class Class_7_2_Static :MonoBehaviour
    {
        //非靜態變數
        public int inventoryWater = 10;
        // 靜態變數: 修飾詞後面添加關鍵字 static
        // 靜態變數不顯示在屬性面板上;
        public static int inventoryProp = 20;

        private void Awake()
        {
            inventoryWater = 6;
            inventoryProp = 30;
            Debug.Log($"<color=green>藥水: {inventoryWater} </color>");
            Debug.Log($"<color=aqua>藥水: {inventoryProp} </color>");

        }
    }
}
