using UnityEngine;

namespace honordes
{
    public class 練習_7_屬性 : MonoBehaviour
    {
        //定義唯讀屬性「血量」
        [SerializeField]
        private float _hp = 100;
        public int hpHearts { get; } = 0;


        public float hp
        {
            get
            {
                if (_hp <= 0) Debug.Log("玩家角色死亡了");
                { 
                    return _hp;                
                }
            }
        }

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
