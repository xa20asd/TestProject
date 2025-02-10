using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 練習存取資料用
    /// </summary>
    public class Class_7_1_GetData : MonoBehaviour
    {
        public Class_7_1_Property property;

        private void Awake()
        {
            //取得另一個類別的資料
            Debug.Log(property.moveSpeed);   //可以取得公開變數
            //Debug.Log(property.turnSpeed); //不可以取得私人變數

            //設定另一個類別資料
            property.moveSpeed = 7.3f; //可以取得公開變數
            //property.turnSpeed = 5.4f; //不可以取得私人變數

            Debug.Log(property.runSpeed); //可以取得公開變數
            //Debug.Log(property.sprintSpeed); //不可以取得私人變數

            property.runSpeed = 66.6f;     //可以設定有 get 的屬性
            //property.jumpSpeed = 55.2f;  //不可設定沒有 set 的屬性(唯讀)

          

        }
    }
}
