using UnityEngine;

namespace honordes
{
    /// <summary>
    /// NPC���O: NPC �W�ٻP��ܤ��e��ơA����XNPC�W��
    /// </summary>
    public class Class_8_1_NPC :MonoBehaviour
    {
        private string name;
        private string dialogue;

        //�غc�l: �S���Ǧ^�����A�W�ٻP���O�ۦP�����}��k
        //�w�]�غc�l:�S���Ѽ�
        public Class_8_1_NPC()
        {
            Debug.Log("�w�]�غc�l");
        }
        public Class_8_1_NPC(string _name)
        { 
            name = _name;
            Debug.Log("���Ѽƪ��غc�l");
        }


        public void LogName()
        {
            Debug.Log($"NPC���W��: {name}");
        }
        public void Talk()
        {
            Debug.Log($"<color=aqua>{dialogue}</color>");
        }
    }
}
