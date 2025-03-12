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

            #region 堆疊
            //堆疊: 先進後出(適合卡牌遊戲)
            Stack<string> enemys = new Stack<string>();
            // 放資料進入堆疊
            enemys.Push("史萊姆");
            enemys.Push("鎖刃龍");
            LogStack<string>(enemys);
            //拿資料且不移除
            enemys.Peek();
            LogStack<string>(enemys);
            //拿資料並移除
            enemys.Pop();
            LogStack<string>(enemys);
            //判斷是否有包含某筆資料
            Debug.Log($"{enemys.Contains("鎖刃龍")}");
            //清除所有資料
            enemys.Clear();
            LogStack<string>(enemys);
            #endregion

            #region 佇列
            //Queue 佇列: 先進先出，先放進來的資料先被拿出來(適合遊戲的攻擊順序)
            Queue<string> player = new Queue<string>();
            player.Enqueue("盜賊");
            player.Enqueue("劍士");
            player.Enqueue("法師");
            LogQueue<string>(player);
            //取資料不刪除，與堆疊的Peek相同
            Debug.Log(player.Peek());
            LogQueue<string>(player);
            //取資料並刪除，與堆疊的Pop相同
            Debug.Log(player.Dequeue());
            LogQueue<string>(player); 
            #endregion
        }
        private void LogStack<T>(Stack<T> stack)
        {
            foreach (var item in stack)
            {
                Debug.Log($"堆疊資料:{item}");
            }
        }

        private void LogQueue<T>(Queue<T> queue)
        {
            foreach (var item in queue)
            {
                Debug.Log($"佇列資料{item}");
            }
        }

    }
}
