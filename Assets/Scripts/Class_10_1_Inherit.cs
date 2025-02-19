using UnityEngine;
using honordes;
using honordes.tools;

namespace honordes
{
    /// <summary>
    /// 繼承 inherit
    /// </summary>
    public class Class_10_1_Inherit: MonoBehaviour
    {
        public void Awake()
        {
            var goblin = new Goblin(10, 5);
            Tools.LogMessage($"哥布林大哥的攻擊:{goblin.attack}", "green");
            var slime = new Slime(3, 2);
            Tools.LogMessage($"史萊姆小弟的攻擊:{slime.attack}", "green");

        }
    }

    public class Goblin
    {
        public int attack;          //公開: 所有類別可以存取
        public int defense;
        private float moveSpeed;    //私人: 此類別可以存取
        protected float hp;         //保護: 子類別可以存取

        public Goblin(int _attack, int _defense)
        { 
            attack = _attack;
            defense = _defense;
        }

    }

    // 繼承讓類別可以繼承另一個類別，擁有該類別的成員
    // 子類別 :　父類別
    // C# 僅能提供單一繼承(只能繼承一個類別)

    public class Slime : Goblin
    { 
        public Slime(int _attack, int _defense) : base(_attack, _defense)
        {
            
        }

        public void Initilize()
        {
            attack = 4;         // 公開:可以存取
            //moveSpeed = 5.2f;   // 私人: 無法存取
            hp = 50;            // 保護: 可以存取
        }

    }
    
     
}
