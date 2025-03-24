using UnityEngine;
using System;

namespace honordes
{
    /// <summary>
    /// 背景音樂管理器
    /// </summary>
    public class Class_19_BgmManager : MonoBehaviour
    {
        [SerializeField]
        private Class_19_Event class_19_event;

        // 步驟 3. 訂閱事件 (Unity 習慣在Awake 或 Start 訂閱)
        private void Awake()
        {
            // 事件: 輸入 += 可以使用 Tab 自動完成 > 命名方法 > Enter 完成
            class_19_event.onDead += ChangeBgm;

            class_19_event.onDeadAction += ChangeBgmViaHp;

            class_19_event.onEvent += ChangeBgmEvent;

            class_19_event.onEventWithHp += ChangeBgmEventWithHp;
        }

        private void ChangeBgmEventWithHp(object sender, float e)
        {
            Debug.Log($"發送事件者: {sender}, 參數: {e}");
        }

        private void ChangeBgmEvent(object sender, System.EventArgs e)
        {
            Debug.Log($"發送事件者: {sender}, 參數: {e}");
        }

        private void ChangeBgmViaHp(string arg1, float arg2)
        {
            Debug.Log($"{arg1}, | 血量: {arg2}");
            if (arg2 <= -5) Debug.Log("變更為遊戲結束音樂");
        }

        private void ChangeBgm()
        {
            Debug.Log("變更音樂");
        }
    }
}
