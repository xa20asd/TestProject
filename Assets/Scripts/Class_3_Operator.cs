using System;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �ҵ{3 :�B��l
/// �ɥR: Unity ����ݩʡBUnity�ƥ�
/// </summary>
public class Class_3_Operator : MonoBehaviour
{
    #region  ������ݩ�
    //����ݩ� Field Attribute
    [Header("����")]
    // C# �ܼ� = ��� Field
    public int lv = 1;

    //[����(���ܤ�r)] : �b�ݩʭ��O�ƹ����d�b�ܼƤW�����
    [Tooltip("�o�O���⪺���ʳt�סA����ĳ�W�L100")]
    public float moveSpeed = 2.5f;

    //[�d��(�̤p,�̤j)]: ���ƭ������K�[�d��(�����W���Ʊ즡)
    [Range(1, 99)]
    public byte count = 10;

    //[Range] ����Φb�D�ƭ������W�A�|���"Use Range With..."
    [Range(10, 99)]
    public string weapon = "�M";

    //[��r�d��(�̤p��, �̤j��)]: �ϥΦb�r��W�A�]�w���O�W����r�ؽd��
    [TextArea(2, 7)]
    public string itemDescription = "�o��M�W���r��!  �ڻQ...";


    //�h������ݩ�
    [Header("��q")][Range(0, 999)]
    public int hp = 100;
    [Header("�����O")]
    [Range(0, 50)]
    public float attack = 30.5f;

    //[�b�ݩʭ��O����] :�N���}�ܼ�����
    [HideInInspector]
    public string password = "�ڬO�K�X";

    //[�ǦC��]: �N�p�H�ܼ����
    [SerializeField]
    private float mp = 500;
    #endregion

    //�ϥ� Unity���ƥ�
    // 1.�����b�}���᭱�K�[ : MonoBehaviour(�~��)
    // 2.�ϥ�����r�ֳt�����A ex ��Jawake�D��n�ϥΪ��ƥ��Enter
    // ������: ����C����|���檺�Ĥ@�Өƥ�A�u����@��
    // �ƥ�W�٬O�Ŧ⪺ (�S���ܦ⤣�v�T)
    private void Awake()
    {
        #region ��X�T��
        // �N�p�A�������T����X�� Unity �� Console ����x���O
        // Ctrl + Shift + C �}�ұ���x���O
        Debug.Log("Hello  �ױo");
        Debug.Log(hp);
        Debug.Log("�묹HP" + hp + "�I" + ", �W�[Attack" + attack + "�I");
        Debug.Log("�����O:" + attack); //�r��P�ܼ�
        Debug.Log($"�����O: {attack}"); //$�r���ܼ�
        Debug.Log("�����O: {attack}"); // �S��$

        Debug.Log("<b>����</b>");
        Debug.Log("<color=orange>���</color>");
        Debug.Log("<color=#66aaff>�Ŧ�</color>");
        #endregion

        #region ��ƹB��l
        //�B��l
        // 1.��ƹB��l

        Debug.Log("<color=orange>---��ƹB��l---</color>");
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);
        Debug.Log(10 % 3);

        Debug.Log("<color=#66aaff>---��ƹB��l:�ϰ��ܼ�---</color>");
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);
        Debug.Log(numberA % numberB);
        #endregion

        #region ����B��l
        Debug.Log("<color=orange>---����B��l---</color>");
        //����B��l�A�ϥΫ�|�o��boolean��
        int numberC = 100, numberD = 999;

        Debug.Log(numberC > numberD);
        Debug.Log(numberC >= numberD);
        Debug.Log(numberC < numberD);
        Debug.Log(numberC <= numberD);
        Debug.Log(numberC == numberD);
        Debug.Log(numberC != numberD);
        #endregion

        #region ���L���޿�B��l
        Debug.Log("<color=red>---���L���޿�B��l---</color>");
        //�޿�_�w:�N���L���ܦ��ۤϪ���
        Debug.Log(!true);
        Debug.Log(!false);
        bool boolVarTrue = true, boolVarFalse = false;
        Debug.Log(!boolVarTrue);
        Debug.Log(!boolVarFalse);

        Debug.Log("<color=green>---&& ||---</color>");
        // && ���2��boolean�A�u�n���@��false�N�Ofalse
        Debug.Log(true && true);
        Debug.Log(true && false);
        Debug.Log(false && true);
        Debug.Log(false && false);
        // || ���2��boolean�A�u�n���@��true�N�Otrue
        Debug.Log(true || true);
        Debug.Log(true || false);
        Debug.Log(false || true);
        Debug.Log(false || false);
        #endregion

    }
}
