using honordes.tools;
using Unity.VisualScripting;
using UnityEngine;

namespace honordes
{
    /// <summary>
    /// Abstract 抽象
    /// </summary>
    public class Class_11_Abstract : MonoBehaviour
    {
        private void Awake()
        {
            //抽象類別:
            // 1.必須使用關鍵字 abstract
            // 2.不能被實例化
            // 3. 如果有抽象方法成員，不需要主體 {}
            // 4. 抽象成員必須被子類別實作(override)
            var flyDragon = new FlyDragon();
            var pigMonster = new Pigmonster();
            //var monster = new Monster();  // 錯誤: 無法實例化抽象類別
            flyDragon.Attack();
            pigMonster.Attack();


            // 向上轉型 Upcasting : 實例化後存放到父類別
            // 向上轉型可以使用多型
            Monster fly = new FlyDragon();
            fly.Track();

            FlyDragon fly2 = new FlyDragon();
            fly2.Track();
            fly2.Track(100);

            var fly3 = new FlyDragon();
            fly3.Track();
            fly3.Track(150);

        }
    }

    //abstract 抽象類別
    public abstract class Monster
    {
        public float hp;
        public float moveSpeed;

        //抽象方法不需要主體 亦即是 不用到{}
        public abstract void Attack();

        public void Track()
        {
            Tools.LogMessage("追蹤", "purple");
        }
        
    }

    public class FlyDragon : Monster
    {
        public override void Attack()
        {
            Tools.LogMessage("毒爪攻擊", "orange");
        }
        public void Track(int speed)
        {
            Tools.LogMessage($"追蹤速度: {speed}", "green");
        }
    }

    public class Pigmonster : Monster
    {
        public override void Attack()
        {
            Tools.LogMessage("衝撞攻擊", "orange");
        }
    }

}