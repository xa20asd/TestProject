using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 類別 Class
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        //類別
        //用來定義一個物件以及它所擁有的資料與功能(成員)

        private void Awake()
        {
            //實例化 NPC 並儲存npcJohn變數內
            Class_8_1_NPC npcJohn = new Class_8_1_NPC("John");
            Class_8_1_NPC npcBob = new Class_8_1_NPC("Bob", "你好啊!!");

            npcJohn.LogName();
            npcJohn.Talk();
            npcBob.LogName();
            npcBob.Talk();
        }

    }
}
