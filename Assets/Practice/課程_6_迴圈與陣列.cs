using UnityEngine;

public class 課程_6_迴圈與陣列: MonoBehaviour
{
    //宣告三維陣列
    public string[,,] character =
    {
        {{"代歐奇希斯", "皮卡丘" },{"烈空座", "火雉雞"}, {"水躍魚", "新葉喵"}},
        {{"綠寶", "木妖" },{"露希妲", "炎魔"}, {"菇菇寶貝", "黑龍王"}},
        {{"提摩", "拉克絲" },{"維珈", "蓋倫"}, {"葛雷夫", "阿祈爾"}}
    };

    private void Awake()
    {
        Debug.Log($"<color=yellow>神奇寶貝:{character[0,0,1]}</color>");
        Debug.Log($"<color=orange>楓之谷怪物:{character[1,2,0]}</color>");
        Debug.Log($"<color=green>英雄聯盟角色:{character[2,1,1]}</color>");
        Debug.Log($"<color=aqua>角色[1,0,2]:{character[1,0,2]}</color>");
    }
}
