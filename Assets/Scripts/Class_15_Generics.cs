using Unity.VisualScripting;
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
            #region 不使用泛型
            int numberA = 7, numberB = 9;
            Debug.Log($"數字 A 與 B: {numberA} | {numberB}");
            SwapNumber(ref numberA, ref numberB);
            Debug.Log($"數字 A 與 B: {numberA} | {numberB}");

            char charA = '好', charB = '阿';
            Debug.Log($"數字 A 與 B: {charA} | {charB}");
            SwapChar(ref charA, ref charB);
            Debug.Log($"數字 A 與 B: {charA} | {charB}");

            object objA = 3.5f, objB = 8.8f;
            Debug.Log($"物件 A 與 B: {objA} | {objB}");
            SwapObject(ref objA, ref objB);
            Debug.Log($"物件 A 與 B: {objA} | {objB}");
            #endregion

            bool boolA = true, boolB = false;
            Debug.Log($"A 與 B: {boolA} | {boolB}");
            Swap<bool>(ref boolA, ref boolB);
            Debug.Log($"A 與 B: {boolA} | {boolB}");

            byte byteA = 1, byteB = 9;
            Debug.Log($"A 與 B: {byteA} | {byteB}");
            Swap<byte>(ref byteA, ref byteB);
            Debug.Log($"A 與 B: {byteA} | {byteB}");

            var player1 = new DataPlayer<int>();
            player1.data = 99;

            var player2 = new DataPlayer<string>();
            player2.data = "玩家2號";
        }

        private void Start()
        {
            var player = new Player();
            var enemy = new Enemy();
            var attackEvent = new AttackEvent<Player, Enemy>();
            attackEvent.Attack(player, enemy);

            var hp = new Hp();
            var attack = new Attack();
            hp.Increase(10.5f);
            attack.Increase(50);
            hp.Increase(3.75f);

            var checker = new CheckValue<Hp,float>();
            checker.Check(hp);

        }

        #region 方法區域

        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapNumber(ref int a, ref int b)
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

        /// <summary>
        /// 使用泛型進行對調
        /// </summary>
        /// <typeparam name="T">要對調的資料類型</typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        } 
        #endregion
    }

    #region 泛型類別
    public class DataPlayer<T>
    {
        public T data;

        public void LogData(T data)
        {
            Debug.Log(data);
        }
    }
    public class Player { }
    public class Enemy { }

    public class AttackEvent<T, U>
    {
        public void Attack(T attacker, U defender)
        {
            Debug.Log($"{attacker} 攻擊 {defender}");
        }
    }
    #endregion

    #region 泛型介面
    //泛型介面
    public interface IStat<T>
    {
        T value { get; set; }               //該狀態的值
        public void Increase(T amount);     //增加該狀態
    }

    public class Hp : IStat<float>
    {
        public float value { get; set; }
        public void Increase(float amount)
        {
            value += amount;
            Debug.Log($"血量: {value}");
        }
    }

    public class Attack : IStat<int>
    {
        public int value { get; set; }
        public void Increase(int amount)
        {
            value += amount;
            Debug.Log($"攻擊力: {value}");
        }
    }
    #endregion

    //泛型約束: T 必須實作 IStat<U> 介面
    //U 可以是任何類型
    public class CheckValue<T, U> where T : IStat<U>
    {
        public void Check(T stat)
        {
            Debug.Log($"狀態的值:{stat.value}");
        }
    }
}
