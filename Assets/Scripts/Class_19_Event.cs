﻿using System;
using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 事件: 當一件事情發生後會通知所有系統
    /// 需要對應處理的系統，可以訂閱並做出處理
    /// 
    /// example :  死亡事件
    /// 玩家系統 > 當角色死亡會執行死亡事件通知其他系統
    /// 控制系統 > 訂閱死亡事件 > 停止控制系統
    /// 音樂系統 > 訂閱死亡事件 > 變更BGM
    /// </summary>
    public class Class_19_Event : MonoBehaviour
    {
        // 事件使用步驟
        // 1.宣告事件(委派)
        // 2.呼叫事件 (什麼時間點要觸發)
        // 3.其他系統訂閱事件

        private float hp = 10;

        // 步驟 1. 宣告事件
        public delegate void delegateMethod();
        // 事件關鍵字: event
        public event delegateMethod onDead;

        public event Action<string, float> onDeadAction;

        // C# 內建的事件: 無參數、有參數
        public event EventHandler onEvent;
        public event EventHandler<float> onEventWithHp;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) Damage(5);
            
        }

        private void Damage(float damage)
        { 
            hp -= damage;
            if (hp <= 0)
            {
                Debug.Log("玩家死亡");

                //步驟2. 呼叫事件
                onDead?.Invoke();                           // ?問號: 判斷 onDead 如果有訂閱才會呼叫
                onDeadAction?.Invoke("玩家", hp);           //事件有參數時呼叫要帶入   
                onEvent?.Invoke(this, EventArgs.Empty);     //呼叫內建事件必須要有2個參數
                onEventWithHp.Invoke(this, hp);             //呼叫內建事件必須要有參數
            }
        }
    }
}
