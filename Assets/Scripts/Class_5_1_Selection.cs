using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//�R�W�Ŷ�
//�N���O�����A�����ܮw�������A���P�ܮw�i�H���ۦP�W�����O
//�y�k: namespace �R�W�Ŷ��W�� {���e}
namespace honordes
{
    /// <summary>
    /// ������z�� Selection Statement
    /// 1. if �P�_��
    /// 2. Switch �P�_��
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour
    {

        [SerializeField, Header("�O�_�}��")]
        private bool isOpen;

        [SerializeField, Header("����"), Range(0, 100)]
        private int score = 100;

        [SerializeField, Header("�Z��")]
        private string weapon;

        private void Awake()
        {
            // if �P�_��
            // if (���L��)
            if (true)
            {
                Debug.Log("��boolean��True");
            }
            //�ֳt����: ��Jif ���
            if (false)
            {
                Debug.Log("��boolean��false");
            }
        }

        //��s�ƥ�: �@���������60��( 60FPS) Frame per Second
        private void Update()
        {
            //�`�Χֱ���
            //1.�榡��  ctrl + K D
            //2. �{���X���q ctrl + K S  ��region
            #region �P�_��if
            Debug.Log("<color=red>��s�ƥ�</color>");

            //�p�GisOpen���� True�A�N��ܤw�g�}��
            if (isOpen)
            {
                Debug.Log("<color=green>�w�g�}��</color>");
            }

            //�_�hisOpen����false�A�N��ܪ����F
            else
            {
                Debug.Log("<color=green>�����F</color>");
            }

            //����B��l�A�޿�B��l���G��boolean
            // ����>= 60 �q�L
            if (score >= 60)
            {
                Debug.Log("<color=orange>����C#�q�L�F</color>");
            }
            // ����>= 40 ���ɦҾ��|
            else if (score >= 40)
            {
                Debug.Log("<color=orange>�A�i�H�ɦҪ�</color>");
            }
            // ����>= 20 ���ɦҾ��|�A���n�B�~���Ӥp�M�D�Ӹɤ�
            else if (score >= 20)
            {
                Debug.Log("<color=orange>�A�i�H�ɦҪ��A���n�B�~���p�M�D�Ӹɤ�</color>");
            }
            //�_�h�A�Q��
            else
            {
                Debug.Log("<color=orange>�ܥi��C#�Q��F</color>");
            }
            #endregion

            #region �P�_��switch
            //switch �P�_��
            //switch (�n�P�_����) {���z��}
            switch (weapon)
            {
                //case ��:
                //��P�_���ȵ���Ȯɷ|����o��
                //break;  ���X�P�_��
                case "�p�M":
                    //�Z������p�M�A��ܧ����O��20
                    Debug.Log("<color=purple>�����O: 20</color>");
                    break;
                //�Z������j�M�A��ܧ����O��35
                case "�j�M":
                    Debug.Log("<color=purple>�����O: 35</color>");
                    break;
                //�Z������w�M�A��ܧ����O��25
                case "�w�M":
                    Debug.Log("<color=purple>�����O: 25</color>");
                    break;

                // ��weapon ���Ȥ�����W�����Ҧ��ȫh�|����U�C�{���X
                default:
                    Debug.Log("<color=purple>�L�����O</color>");
                    break;
            } 
            #endregion
        }



    }
}
