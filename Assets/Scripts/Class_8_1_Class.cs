using UnityEngine;

namespace honordes
{
    /// <summary>
    /// ���O Class
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        //���O
        //�Ψөw�q�@�Ӫ���H�Υ��Ҿ֦�����ƻP�\��(����)

        private void Awake()
        {
            //��Ҥ� NPC ���x�snpcJohn�ܼƤ�
            Class_8_1_NPC npcJohn = new Class_8_1_NPC();
            Class_8_1_NPC npcBob = new Class_8_1_NPC("Bob");

            npcJohn.LogName();
            npcBob.LogName();
        }

    }
}
