using UnityEngine;
using honordes.tools;


namespace honordes
{
    /// <summary>
    /// Boss類別
    /// </summary>
    public class 練習_8_Boss :MonoBehaviour
    {
        private string name, finalMovesName;
        private int hp;

        //實作建構子
        public 練習_8_Boss(string name1, string finalMovesName1 , int hp1)
        {
            name = name1;
            finalMovesName = finalMovesName1;
            hp = hp1;
        }

        //顯示BOSS的資訊
        public void Bossinfo()
        {
        //    Debug.Log($"<color=yellow>BOSS名稱: {name}</color>");
        //    Debug.Log($"<color=green>BOSS的大絕招名稱: {finalMovesName}</color>");
        //    Debug.Log($"<color=aqua>BOSS血量: {hp}</color>");

            Tools.LogMessage("BOSS名稱:" + name + ",BOSS的大絕招名稱:" + finalMovesName + ",BOSS血量:" + hp, "orange");

        }

    }

}
