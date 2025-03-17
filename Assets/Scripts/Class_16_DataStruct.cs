using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

namespace honordes
{
    /// <summary>
    /// 資料結構
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

            #region 鏈結串列
            // LinkedList 鏈結串列
            string[] skillArray = new string[] { "火球", "冰錐" };
            LinkedList<string> skills = new LinkedList<string>(skillArray);
            LogLinkedList<string>(skills);
            skills.AddLast("落雷");
            LogLinkedList<string>(skills);
            skills.AddFirst("岩封");
            LogLinkedList<string>(skills);

            // 在火球後面添加毒霧
            LinkedListNode<string> skillFire = skills.Find("火球");
            skills.AddAfter(skillFire, "毒霧");
            // 在火球前面添加瞬移
            skills.AddBefore(skillFire, "瞬移");
            LogLinkedList<string>(skills);

            #endregion

            #region 排序集合
            // 自動排序並且不重複的集合(由小到大的排序)
            SortedSet<int> counts = new SortedSet<int> { 9, 33, 19, 1, 95, 0 };
            LogSortedSet<int>(counts);
            counts.Add(77);
            counts.Add(111);
            counts.Add(3);
            LogSortedSet<int>(counts);
            Debug.Log($"最大: {counts.Max}");
            Debug.Log($"最小: {counts.Min}");

            SortedSet<int> lv = new SortedSet<int> { 43, 32, 5, 12, 4 };
            // 交集
            counts.IntersectWith(lv);
            LogSortedSet<int>(counts);
            // 差集
            counts.ExceptWith(lv);
            LogSortedSet<int>(counts);

            SortedSet<int> countset1 = new SortedSet<int> { 9, 2, 80, 1 };
            SortedSet<int> countset2 = new SortedSet<int> { 9, 2 };
            //countset1.IntersectWith(countset2);
            countset1.ExceptWith(countset2);
            LogSortedSet<int>(countset1);
            #endregion

            #region 字典
            Dictionary<int, string> deck = new Dictionary<int, string>()
            {
                {10, "真紅眼黑龍" },{3, "落穴" },{5, "魔法少年賈修" }
            };
            LogDictionary<int, string>(deck);
            deck.Add(7, "死者甦醒");
            Debug.Log($"是否有編號3資料: {deck.ContainsKey(3)}");
            Debug.Log($"是否有羽毛掃資料: {deck.ContainsValue("羽毛掃")}"); 
            #endregion

            // 保持排序並且不會有重複的鍵
            SortedList<string, int> board = new SortedList<string, int>();
            board.Add("Apple", 87);
            board.Add("Banana", 90);
            board.Add("Canada", 99);
            //board.Add("Canada", 57);
            LogSortedList<string, int>(board);

            //// 保持排序並且不會有重複鍵的字典
            SortedDictionary<string, int> scores = new SortedDictionary<string, int>();
            scores.Add("Apple", 87);
            scores.Add("Banana", 90);
            scores.Add("Canada", 99);
            //scores.Add("Canada", 99);
            LogSortedDictionary<string, int>(scores);

            // SortedList 與 SortedDictionary 的差異
            // 1.SortedList 是使用陣列方式儲存，比較省RAM
            // 2.SortedDictionary 是使用樹狀結構方式儲存，比較佔RAM
            // 3.SortedList 可以使用索引值存取[0]
            Debug.Log(board.Keys[0]);
            
            // 4.SortedList 大量資料增減時比較佔RAM
            // 如果資料不需要頻繁地增減建議使用SortedList反之建議 SortedDictionary

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

        private void LogLinkedList<T>(LinkedList<T> linkedList)
        {
            foreach (var item in linkedList)
            {
                Debug.Log(item);
            }
            Debug.Log("------------------");
        }

        private void LogSortedSet<T>(SortedSet<T> set)
        {
            foreach (var item in set)
            {
                Debug.Log(item);
               
            }
            Debug.Log("-------------");
        }

        private void LogDictionary<T, U>(Dictionary<T, U> dict)
        {
            foreach (var item in dict)
            {
                Debug.Log($"<color=orange>卡牌編號{item.Key}</color>");
                Debug.Log($"<color=orange>卡牌編號{item.Value}</color>");
            }
            Debug.Log("---------------");
        }

        private void LogSortedList<T, U>(SortedList<T, U> list)
        {
            foreach (var item in list)
            {
                Debug.Log($"{item.Key}的分數: {item.Value}");
            }
            Debug.Log("---------------");
        }

        private void LogSortedDictionary<T, U>(SortedDictionary<T, U> list)
        {
            foreach (var item in list)
            {
                Debug.Log($"<color=aqua>{item.Key}的分數: {item.Value}</color>");
            }
            Debug.Log("---------------");
        }

    }
}
