using System;
using UnityEngine;

namespace honordes 
{
    /// <summary>
    /// 例外處理
    /// </summary>
    public class Class_18_Exception : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log($"{Division(8, 4)}");
            Debug.Log($"{Division(3, 9)}");
            Debug.Log($"{Division(7, 0)}");
            Debug.Log($"{GetScores(0)}");
            Debug.Log($"{GetScores(4)}");
            Debug.Log($"{GetScores(8)}");

            SetEnemy();
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="numberA">分母</param>
        /// <param name="numberB">分子</param>
        /// <returns></returns>
        // int? 允許傳回空值
        private int? Division(int numberA, int numberB)
        {
            // 可能發生例外的區域
            try
            {
                return numberA / numberB; // 發生例外
            }
            // 捕捉到例外為「除以零」時會執行此區域
            catch (DivideByZeroException e)
            {
                Debug.LogError($"分子不能為零 | {e.Message}");
                return null;
            }

            //最後區域
            finally
            {
                Debug.Log("例外處理完畢");
            }
        }

        private int[] scroes = { 70, 99, 41, 32, 66 };
        private int? GetScores(int index)
        {
            try
            {
                return scroes[index];
            }
            catch (DivideByZeroException)
            {
                Debug.Log("發生例外");
                return null;
                
            }
            catch (IndexOutOfRangeException e)
            {
                Debug.Log($"發生例外 | {e.Message}");
                return null;
            }
        }

        [SerializeField]
        private GameObject enemy;

        /// <summary>
        /// 設定敵人物件
        /// </summary>
        private void SetEnemy()
        {
            try
            {
                enemy.SetActive(true); //顯示敵人物件
            }
            catch (Exception e)  // Exception 可以處理所有例外
            {
                Debug.Log($"發生例外: {e.Message}");
            }
        }
    }
}
