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
    }

    //類別:
    // 1. 繼承:允許繼承
    // 2.建構子可以有多個建構子
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

