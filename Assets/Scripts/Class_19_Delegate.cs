using System;
using UnityEngine;

namespace honordes
{
    /// <summary>
    /// 委派
    /// </summary>
    public class Class_19_Delegate : MonoBehaviour
    {
        private void Awake()
        {
            Cure(10);
            Card(("哥布林", 7));
        }

        #region 複習可當參數的變數與元組
        // 將float當作參數

        private void Cure(float cure)
        {
            Debug.Log($"治癒的值: {cure}");
        }

        //將元組 當作參數
        private void Card((string name, int index) card)
        {
            Debug.Log($"卡片: {card.name} | {card.index}");
        } 
        #endregion

        // 1.宣告委派:簽章 (傳回與參數)
        // 宣告一個無傳回與無參數的委派
        private delegate void DelegateMethod();
        private delegate float Calculate(float numberA, float numberB);
        private delegate void DelegateCombine<T>(T a);  //使用泛型

        // 2.目標方法: 簽章必須與委派相同
        #region 無傳回與無參數方法
        private void Test()
        {
            Debug.Log("測試");
        }

        private void Talk()
        {
            Debug.Log("哈囉! 你好");
        }
        private void MagicCard()
        {
            Debug.Log("召喚小兵");
        }
        #endregion

        private float Add(float numberA, float numberB)
        { 
            float result = numberA + numberB;
            Debug.Log(result);
            return result;
        }
        private float Sub(float numberA, float numberB)
        {
            float result = numberA - numberB;
            Debug.Log(result);
            return result;

        }
        private float Mul(float numberA, float numberB)
        {
            float result = numberA * numberB;
            Debug.Log(result);
            return result;

        }

        private void Combine<T>(T a)
        {
            Debug.Log(a);
        }

        // 3.宣告變數存放方法(預設為空值)
        private DelegateMethod delegateMethod;
        private Calculate calculate;
        private DelegateCombine<float> delegateCombineFloat;
        private DelegateCombine<int> delegateCombineInt;

        // Func
        // 可以存放有傳回並且有0個參數以上的方法
        // 宣告一個委派，有一個參數 float ，並且傳回值為float
        // <參數，傳回值>
        private Func<float, float> funcCalc;

        // Action
        // 可以存放無傳回並且有0個參數以上的方法
        // 宣告一個委派，沒有參數也沒有傳回值
        private Action actionMethod;

        // Predicate
        // 可以存放有布林值傳回並且只有1個參數的方法
        // 宣告一個委派，有一個參數float，並且傳回值為bool
        private Predicate<float> predicate;

        // 4.呼叫委派
        private void Start()
        {
            #region 基本委派
            delegateMethod = Test;          // 將方法存放到變數 delegateMethod 內
            delegateMethod += Talk;         // 多播委派:　一個委派存放多個方法，相同簽章
            delegateMethod += MagicCard;    //可添加多個方法
            delegateMethod -= Test;         //也可刪除方法
            delegateMethod();               // 呼叫委派 
            #endregion

            #region 多播委派與泛型委派
            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            calculate(10, 3);
            calculate(100, 70);

            CalculateNumber(Sub, 5, 3);     //將方法當作參數傳遞

            delegateCombineFloat = Combine<float>;
            delegateCombineFloat(5.5f);
            delegateCombineInt = Combine<int>;
            delegateCombineInt(999);
            #endregion

            #region 匿名方法
            //匿名方法
            //delegate (參數) {陳述式}
            DelegateMethod anonymousMethod = delegate () { };
            Calculate anonymousCalc = delegate (float a, float b) { return a * b; };

            //簡寫方式
            DelegateMethod anonymousMethod2 = () => { };
            Calculate anonymousCalc2 = (a, b) => { return a * b; };

            CalculateNumber(Add, 3, 7);
            CalculateNumber(anonymousCalc, 3, 7);
            CalculateNumber(anonymousCalc2, 3, 7);

            //在參數上面使用匿名方法
            CalculateNumber(delegate (float a, float b) { return a / b; }, 12, 4);
            CalculateNumber((a, b) => { return a / b; }, 12, 4);
            #endregion

            funcCalc = delegate (float x) { return x * 10; };
            Debug.Log($"Func 委派: {funcCalc(3.5f)}");

            actionMethod = delegate () { Debug.Log("Action 委派"); };
            actionMethod();

            predicate = delegate (float x ) { return x > 0; };
            Debug.Log($"Predicate 委派: 7 是否大於零 - {predicate(7)}");

            // Lambda 運算子 =>
            // (參數) => {陳述式}
            Action action = () => { Debug.Log("Lambda練習"); };
            action();

            Func<int, string> func = (x) => { return $"Lambda練習，數字: {x}"; };
            Debug.Log($"{func(77)}");

            Predicate<string> predicateTest = (x) => { return x.Length > 0; };
            Debug.Log($"{predicateTest("菇菇寶貝")}");
        } 

        

        // 委派: 將方法當作參數
        private void CalculateNumber(Calculate calculate, float a ,float b)
        {
            var result = calculate(a, b);
            Debug.Log(result);
        }
    }
}
