using UnityEngine;
using honordes.tools;

namespace honordes
{
    /// <summary>
    /// 多型 Polymorphism
    /// </summary>
    public class Class_10_2_Polymorphism: MonoBehaviour
    {
        private void Awake()
        {
            Trap trap1 = new Trap("落穴", 3);
            Magic magic1 = new Magic("死者復甦", 5);

            //多型: 多種型式，可以使用父類別或者自己的成員
            trap1.Information();    //型式1 :呼叫父類別的無參數方法
            trap1.Information(37);  //型式2 :呼叫自己有一個參數方法

            //多型: 宣告時使用父類別
            Card card1 = new Card("一般卡片", 0);
            Card magic2 = new Magic("落雷", 5);
            card1.Information();    //型式1:呼叫Card的方法
            magic2.Information();   //型式2:呼叫Magic的方法

        }
    }
    public class Card
    {
        public string name;
        public int cost;
        public Card(string _name, int _cost)
        {
            name = _name;
            cost = _cost;
        }
        public virtual void Information()
        {
            Tools.LogMessage($"{name}這是一張卡牌", "aqua");
        }
    }
    public class Trap : Card
    {
        //public Trap(string _name, int _cost)
        //{
        //}
        public void Information(int index)
        {
            Tools.LogMessage($"這是一張陷阱卡牌，編號:{index}", "orange");
        }
    }
    public class Magic : Card
    {
        //public Magic(string _name, int _cost)
        //{ 
        //}
        public override void Information()
        {
            Tools.LogMessage($"{name}，這是一張魔法卡牌", "green");
        }
    }
}
