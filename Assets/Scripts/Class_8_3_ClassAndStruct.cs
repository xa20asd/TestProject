using honordes.tools;
using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 類別與結構的差異
    /// </summary>
    public class Class_8_3_ClassAndStruct :MonoBehaviour
    {
        private void Awake()
        {
            //3.空值: 類別可以空值，結構不行
            練習_8_類別 class1 = new 練習_8_類別(); //有實例化
            練習_8_類別 class2 = null;              //空值

            Class_8_3_Struct struct1 = new Class_8_3_Struct(); //有實例化
            //Class_8_3_Struct struct2 = null;                     //空值

            Tools.LogMessage(class1.ToString(), "orange");
            //Tools.LogMessage(class2.ToString(), "yellow");
            Tools.LogMessage(struct1.ToString(), "orange");
            //Tools.LogMessage(struct2.ToString(), "yellow");

        }
        private void Start()
        {
            //var 不指定類型，可以儲存所有資料
            var testClass1 = new Class_8_4_Class("我是類別1");
            var testStruct1 = new Class_8_4_Struct("我是結構1");
            var testClass2 = new Class_8_4_Class("我是類別2");
            var testStruct2 = new Class_8_4_Struct("我是結構2");

            Tools.LogMessage(testClass1.name, "aqua");
            Tools.LogMessage(testStruct1.name, "aqua");
            Tools.LogMessage(testClass2.name, "aqua");
            Tools.LogMessage(testStruct2.name, "aqua");

            testClass2 = testClass1;   //傳址: class1與class2指向同一個地址
            testStruct1 = testStruct2; //傳值: struct1與struct2 指向同一個值

            //修改class1 或  class2 資料都會被同步
            testClass1.name = "類別";
            Tools.LogMessage(testClass1.name, "orange");
            Tools.LogMessage(testClass2.name, "orange");

            //修改struct1 或  struct2 資料不會被同步
            testStruct1.name = "結構";
            Tools.LogMessage(testStruct1.name, "green");
            Tools.LogMessage(testStruct1.name, "green");


        }
    }

    //類別:
    // 1. 繼承:允許繼承
    // 2.建構子可以有多個建構子
    // 3. 資料類型: 參考型別 Reference　Type
    public class Class_8_3_Class : MonoBehaviour
    {
        public Class_8_3_Class()
        {

        }
        public Class_8_3_Class(int test)
        {

        }
    }

    //結構:
    // 1. 結構:不允許繼承
    // 2.不能有無參數建構子
    // 3. 資料類型: 實值型別 Value Type 
    public struct Class_8_3_Struct
    {
        //public Class_8_3_Struct()
        //{ 
            
        //}
        public Class_8_3_Struct(int test)
        {

        }
    }



}

