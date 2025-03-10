using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 介面 Interface
    /// </summary>
    public class Class_15_Interface :MonoBehaviour
    {
        public object invertoryFirst;
        public object invertorySec;
        private void Awake()
        {
            //var prop = new Prop();
            //var equip = new Equipment();
            //var map = new Map();

            //prop.Use();
            //equip.Use();
            //map.Use();

            int random = Random.Range(0, 3);
            Debug.Log($"隨機: {random}");
            
            if(random == 0) invertoryFirst = new Prop();
            else if (random == 1) invertoryFirst = new Equipment();
            else if (random == 2) invertoryFirst = new Map();

            int randomSec = Random.Range(0, 3);
            Debug.Log($"隨機: {random}");

            if (randomSec == 0) invertorySec = new Weapon();
            else if (randomSec == 1) invertorySec = new Potion();
            else if (randomSec == 2) invertorySec = new Chest();
        }

        private void Update()
        {
            // 按下數字鍵 1 可以使用第一個物品
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                // 如果第一格是道具，就使用道具
                if (invertoryFirst is Prop) ((Prop)invertoryFirst).Use();

                // 如果第一格是裝備，就使用裝備
                if (invertoryFirst is Equipment) ((Equipment)invertoryFirst).Use();

                // 如果第一格是地圖，就使用地圖
                if (invertoryFirst is Map) ((Map)invertoryFirst).Use();

                // 如果當項目種類越多之後，判斷式會越來越長...
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                // 如果第二格道具的物品有實作介面，就使用道具
                if (invertorySec is IUse) ((IUse)invertorySec).Use();

                if (invertorySec is IDestroy) ((IDestroy)invertorySec).Destroy();

                //如果擴充物品，判斷式不需要添加，只需要讓物品都實作介面即可
            }
        }



    }
    public class Prop
    {
        public void Use()
        {
            Debug.Log("使用道具");
        }
    }
    public class Equipment
    {
        public void Use()
        {
            Debug.Log("使用裝備，裝到對應位置");
        }
    }
    public class Map
    {
        public void Use()
        {
            Debug.Log("使用地圖，開啟地圖功能");
        }
    }
}
