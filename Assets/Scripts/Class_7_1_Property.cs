using UnityEngine;


namespace honordes
{
    /// <summary>
    /// �ݩ� Property
    /// </summary>
    public class Class_7_1_Property : MonoBehaviour
    {
        #region �{���ݩ� property
        //���}�ܼ�: �i�H���~��Ū���P�g�J
        public float moveSpeed = 3.5f;

        //�p�H�ܼ�: �����\�~��Ū���P�g�J
        private float turnSpeed = 8.5f;

        //���}�ݩ�: ���\�s��
        public float runSpeed { get; set; }
        //�p�H�ݩ�: �����\�s��
        private float sprintSpeed { get; set; }
        //���}�ݩ�: �u��get�N���Ū (�u��Ū������g�J)
        public float jumpSpeed { get; }

        //prop + Tab
        // ���w�]�Ȫ��ݩ�
        public int lv { get; set; } = 1;
        private void Awake()
        {
            Debug.Log("-----���o�ܼƻP�ݩ�---");
            Debug.Log(moveSpeed);
            Debug.Log(turnSpeed);
            Debug.Log(runSpeed);
            Debug.Log(jumpSpeed);
            Debug.Log(lv);
            Debug.Log("-----���o�ܼƻP�ݩ�---");
            moveSpeed = 65.3f;
            turnSpeed = 3.4f;     //�p�H�ܼƦb���O���i�H�]�w
            runSpeed = 40.4f;
            sprintSpeed = 96.3f;
            //jumpSpeed = 33;       //�S��set���ݩʦb���O���]�L�k�]�w
            lv = 10;

        }
        #endregion

        //�ݩ�²�g
        public float hp { get; set; } = 100;

        //�ݩʼзǼg�k
        //_mp �ΨӸ��ݩ� mp ���e��
        private float _mp = 50.0f;
        //�ݩʬO�����~���s���v�������f
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

        //���o�ݩʪ�²�g ( �b�Y  =>  Lambda)
        //�߿W�ݩ� ���m�ȬO30 
        public int defense { get; } = 30;
        //�߿W�ݩ� �����ȬO50 
        public int attack => 50;

        private void Start()
        {
            Debug.Log($"<color=green>�]�O: {mp}</color>");
            mp = 400.0f;
            Debug.Log($"<color=aqua>�]�O:{mp}</color>");
        }

    }
}
