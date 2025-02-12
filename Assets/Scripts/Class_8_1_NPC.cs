using UnityEngine;

namespace honordes
{
    /// <summary>
    /// NPC類別: NPC 名稱與對話內容資料，有輸出NPC名稱
    /// </summary>
    public class Class_8_1_NPC :MonoBehaviour
    {
        private string name;
        private string dialogue;

        //建構子: 沒有傳回類型，名稱與類別相同的公開方法
        //預設建構子:沒有參數
        public Class_8_1_NPC()
        {
            Debug.Log("預設建構子");
        }
        public Class_8_1_NPC(string _name)
        { 
            name = _name;
            Debug.Log("有參數的建構子");
        }


        public void LogName()
        {
            Debug.Log($"NPC的名稱: {name}");
        }
        public void Talk()
        {
            Debug.Log($"<color=aqua>{dialogue}</color>");
        }
    }
}
