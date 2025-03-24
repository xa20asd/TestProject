using UnityEngine;
using System.Linq;

namespace honordes
{
    /// <summary>
    /// LINQ 整合查詢語言 Language Intergrated Query
    /// 查詢資料庫，所有程式語言共用技術
    /// </summary>
    public class Class_19_LINQ : MonoBehaviour
    {
        public int[] scores = { 90, 80, 66, 1, 55, 43 };

        private void Awake()
        {
            // 使用LinQ 的關鍵字查詢資料
            // 起手式
            // from 資料來源
            // select 選取結果
            // 說明: 選取 scores 內的每一筆分數
            var queryAllData = from s in scores
                               select s;

            foreach (var data in queryAllData)
            { 
                Debug.Log(data);
            }

            // 情境: 希望找到大於60分的
            // where 篩選條件
            // orderby 排序 (預設從小到大)  descending 由大到小
            var querySixty = from s in scores
                             where s >= 60
                             orderby s /*descending*/
                             select s;
            foreach (var data in querySixty)
            {
                Debug.Log(data);
            }

            //情境: 篩選出分數為偶數的資料與奇數
            //group by
            var querygroup = from s in scores
                             group s by s % 2;
            foreach (var data in querygroup)
            {
                Debug.Log(data);
                foreach (var n in data)
                {
                    Debug.Log(n);
                }
                Debug.Log("-------------");
            }
        }
    }
}
