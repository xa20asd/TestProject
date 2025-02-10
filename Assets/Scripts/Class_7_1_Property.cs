using UnityEngine;


namespace honordes
{
    /// <summary>
    /// 屬性 Property
    /// </summary>
    public class Class_7_1_Property : MonoBehaviour
    {
        #region 認識屬性 property
        //公開變數: 可以讓外部讀取與寫入
        public float moveSpeed = 3.5f;

        //私人變數: 不允許外部讀取與寫入
        private float turnSpeed = 8.5f;

        //公開屬性: 允許存取
        public float runSpeed { get; set; }
        //私人屬性: 不允許存取
        private float sprintSpeed { get; set; }
        //公開屬性: 只有get代表唯讀 (只能讀取不能寫入)
        public float jumpSpeed { get; }

        //prop + Tab
        // 有預設值的屬性
        public int lv { get; set; } = 1;
        private void Awake()
        {
            Debug.Log("-----取得變數與屬性---");
            Debug.Log(moveSpeed);
            Debug.Log(turnSpeed);
            Debug.Log(runSpeed);
            Debug.Log(jumpSpeed);
            Debug.Log(lv);
            Debug.Log("-----取得變數與屬性---");
            moveSpeed = 65.3f;
            turnSpeed = 3.4f;     //私人變數在類別內可以設定
            runSpeed = 40.4f;
            sprintSpeed = 96.3f;
            //jumpSpeed = 33;       //沒有set的屬性在類別內也無法設定
            lv = 10;

        }
        #endregion

        //屬性簡寫
        public float hp { get; set; } = 100;

        //屬性標準寫法
        //_mp 用來裝屬性 mp 的容器
        private float _mp = 50.0f;
        //屬性是給予外部存取權限的窗口
        public float mp
        {
            get
            {
                return _mp;
            }

            set
            {
                _mp = value;
            }
        }

        //取得屬性的簡寫 ( 箭頭  =>  Lambda)
        //唯獨屬性 防禦值是30 
        public int defense { get; } = 30;
        //唯獨屬性 攻擊值是50 
        public int attack => 50;

        private void Start()
        {
            Debug.Log($"<color=green>魔力: {mp}</color>");
            mp = 400.0f;
            Debug.Log($"<color=aqua>魔力:{mp}</color>");
        }

    }
}
