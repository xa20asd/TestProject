using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 泛型  Generics
    /// </summary>
    public class Class_15_Generics : MonoBehaviour
    {
        private void Awake()
        {
            int numberA = 7, numberB = 9;
            Debug.Log($"數字 A 與 B: {numberA} | {numberB}");
            SwapNumber(ref numberA, ref numberB );
            Debug.Log($"數字 A 與 B: {numberA} | {numberB}");

            char charA = '好', charB = '阿';
            Debug.Log($"數字 A 與 B: {charA} | {charB}");
            SwapChar(ref charA, ref charB);
            Debug.Log($"數字 A 與 B: {charA} | {charB}");

            object objA = 3.5f, objB = 8.8f;
            Debug.Log($"數字 A 與 B: {objA} | {objB}");
            SwapObject(ref objA, ref objB);
            Debug.Log($"數字 A 與 B: {objA} | {objB}");

        }

        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapNumber(ref int a,ref int b)
        { 
            int temp = a;   //將第一個數字放去旁邊(暫存)
            a = b;          //第二個數字放到第一個數字內
            b = temp;       //將旁邊的數字放到第二個數字
        }

        /// <summary>
        /// 字元對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;  
            a = b;          
            b = temp;       
        }

        /// <summary>
        /// 物件對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
    }
}
