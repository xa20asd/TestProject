using UnityEngine;
using UnityEngine.SceneManagement;

namespace honordes
{
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class Class_7_2_Static :MonoBehaviour
    {
        #region 變數
        //成員 : 變數、屬性、方法
        //非靜態變數
        public int inventoryWater = 10;
        // 靜態變數: 修飾詞後面添加關鍵字 static
        // 靜態變數不顯示在屬性面板上;
        public static int inventoryProp = 20;

        //非靜態屬性
        public string skillMain => "影分身之術";
        //靜態屬性
        public static string skillSec => "影子之術";

        #endregion
        private void Awake()
        {
            //inventoryWater = 6;
            //inventoryProp = 30;
            Debug.Log($"<color=green>藥水: {inventoryWater} </color>");
            Debug.Log($"<color=aqua>藥水: {inventoryProp} </color>");

        }

        public void Punch()
        {
            Debug.Log("<color=yellow>使用拳擊</color>");
        }
        public static void Kick()
        {
            Debug.Log("<color=aqua>使用踢擊</color>");
        }
        private void Start()
        {
            //在Unity內的差異
            //場景切換時，非靜態成員會被釋放(還原預設值)
            inventoryWater ++; // 藥水+1
            Debug.Log($"<color=orange>藥水: {inventoryWater}</color>");

            //靜態成員不會被釋放(不會還原預設值)
            inventoryProp++;
            Debug.Log($"<color=orange>道具: {inventoryProp}</color>");
        }
        private void Update()
        {
            //如果按數字1(左邊數字鍵1)
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程_7_屬性與靜態");
            }
        }
    }
}
