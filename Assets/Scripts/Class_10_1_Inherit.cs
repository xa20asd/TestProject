using UnityEngine;
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
            var slime1 = new Slime(3, 2);
            Tools.LogMessage($"史萊姆小弟的攻擊:{slime1.attack}", "green");
            goblin.Move();
            slime1.Move();
            slime1.Initilize();

            //判斷史萊姆是否繼承哥布林
            //類別A is 類別B : 布林值
            var slimeIsGoblin = slime1 is Goblin;
            Tools.LogMessage($"史萊姆是否為哥布林:{slimeIsGoblin}", "red");

            var spider1 = new Spider(15, 3);
            var spider1IsSlime = spider1 is Slime;
            var spider1IsGoblin = spider1 is Goblin;
            Tools.LogMessage($"蜘蛛人是否為史萊姆:{spider1IsSlime}", "red");
            Tools.LogMessage($"蜘蛛人是否為哥布林:{spider1IsGoblin}", "red");

        }
    }

    public class Goblin
    {
        public int attack;          //公開: 所有類別可以存取
        public int defense;
        private float moveSpeed;    //私人: 此類別可以存取
        protected float hp;         //保護: 子類別可以存取
        protected int lv = 8;

        public Goblin(int _attack, int _defense)
        { 
            attack = _attack;
            defense = _defense;
        }

        // virtual 虛擬: 允許子類別覆寫
        public virtual void Move()
        {
            Tools.LogMessage("2隻腳移動", "orange");
        }

    }

    // 繼承讓類別可以繼承另一個類別，擁有該類別的成員
    // 子類別 :　父類別
    // C# 僅能提供單一繼承(只能繼承一個類別)
    public class Slime : Goblin
    {
        protected int lv = 3; // 綠色蚯蚓: 提示父類別也有相同的成員名稱
        public Slime(int _attack, int _defense) : base(_attack, _defense)
        {
            
        }

        public void Initilize()
        {
            attack = 4;         // 公開:可以存取
            //moveSpeed = 5.2f;   // 私人: 無法存取
            hp = 50;            // 保護: 可以存取
            Tools.LogMessage($"等級:{lv}", "yellow");
            Tools.LogMessage($"等級:{base.lv}(父類別)", "yellow");
        }

        // override 覆寫: 覆寫父類別有 virtual 關鍵字的成員
        // override 選擇要覆寫的成員 > 按下Enter自動完成
        public override void Move()
        {
            //base.Move();  //父類別原有的內容
            Tools.LogMessage("爬行", "aqua");
        }

        

    }

    public class Spider : Slime
    {
        public Spider(int _attack, int _defense) : base(_attack, _defense)
        {

        }
    }


}
