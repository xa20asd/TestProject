using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 練習取得與設定靜態資料
    /// </summary>
    public class Class_7_2_GetSetData : MonoBehaviour
    {
        // 取得非靜態資料
        //1. 先定義要獲得資料類別的變數
        //2. 透過變數取得非靜態資料(成員)

        public Class_7_2_Static class_7_2;

        private void Awake()
        {
            //變數名稱.非靜態成員
            //取得非靜態變數
            Debug.Log($"<color=red>非靜態成員: {class_7_2.inventoryWater}</color>");
            //取得非靜態屬性
            Debug.Log($"<color=red>非靜態成員: {class_7_2.skillMain}</color>");
            //呼叫非靜態方法
            class_7_2.Punch();


            //取得靜態資料(成員)
            //類別名稱.靜態成員
            Debug.Log($"<color=green>靜態成員: {Class_7_2_Static.inventoryProp}</color>");
            //取得靜態屬性
            Debug.Log($"<color=red>非靜態成員: {Class_7_2_Static.skillSec}</color>");
            //呼叫靜態方法
            Class_7_2_Static.Kick();
        }

        public Class_7_2_Slime slimeGreen, slimeRed;
        
        private void Start()
        {
            //非靜態成員
            slimeGreen.hp -= 10;
            Debug.Log($"史萊姆綠的HP: {slimeGreen.hp}");
            slimeRed.hp -= 30;
            Debug.Log($"史萊姆綠的HP: {slimeRed.hp}");

            //靜態成員
            //靜態成員沒辦法透過個體存取
            //slimeGreen.moveSpeed = 2.0f;
            Class_7_2_Slime.moveSpeed = 3.5f;
            Debug.Log($"史萊姆移動速度: {Class_7_2_Slime.moveSpeed}");
        }
    }

}