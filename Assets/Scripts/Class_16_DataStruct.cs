using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

namespace honordes
{
    /// <summary>
    /// 
    /// </summary>
    public class Class_16_DataStruct :MonoBehaviour
    {
        //陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defends = { 1.5f, 7.5f, 0.3f };

        //清單: 泛型集合
        public List<int> speeds = new List<int>() { 3, 6, 9 };
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playDefends;

        private void Awake()
        {
            #region 清單
            //清單存取: 與陣列相同
            Debug.Log($"第三筆速度: {speeds[2]}");
            speeds[0] = 10;
            Debug.Log($"第三筆速度: {speeds[0]}");

            //陣列初始化後就無法無法增減長度
            Debug.Log($"第一筆物品: {props[0]}");
            props.Add("武器");
            Debug.Log($"第三筆物品: {props[2]}");
            //添加一筆
            props.RemoveAt(0);
            //添加到編號i上
            props.Insert(1, "裝備");
            foreach (var prop in props)
            {
                Debug.Log($"道具:{prop}");
            }

            //使用建構子
            playDefends = new List<float>(defends);
            //排序(值小到大)
            playDefends.Sort();
            foreach (var item in playDefends)
            {
                Debug.Log($" 排序資料:{item}");
            }
            //反排序(值大到小)
            playDefends.Reverse();

            foreach (var item in playDefends)
            {
                Debug.Log($" 反排序資料:{item}");
            }

            //Count 指清單內的資料，根據Add或Remove 改變
            Debug.Log($"列表內數量:{props.Count}");
            // Capacity 指清單內的容量，系統自動分配，預設為4並且以倍數成長(C#各版本不同)
            Debug.Log($"列表內容量:{props.Capacity}");

            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                Debug.Log($"測試列表內數量:{numbers.Count}");
                Debug.Log($"測試列表內容量:{numbers.Capacity}");
            } 
            #endregion

            Stack<string> enemy = new Stack<string>();
            enemy.Push("史萊姆");
            enemy.Push("鎖刃龍");
            LogStack<string>(enemy);

            enemy.Pop(1);

        }
        private void LogStack<T>(Stack<T> stack)
        {
            foreach (var item in stack)
            {
                Debug.Log($"堆疊資料:{item}");
            }
        }

    }
}
