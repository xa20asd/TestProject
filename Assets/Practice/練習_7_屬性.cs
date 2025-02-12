using UnityEngine;

namespace honordes
{
    public class 練習_7_屬性 : MonoBehaviour
    {
        //定義唯獨屬性「血量」
        public int hpHearts { get; } = 0;

        private void Start()
        {
            Debug.Log($"玩家血量:{hpHearts}");
        }

        private void Update()
        {
            if (hpHearts <= 0) 
            {
                Debug.Log($"玩家角色死亡了");
            }
        }


    }

}
