using UnityEngine;

namespace honordes
{
    /// <summary>
    /// �R�A Static
    /// </summary>
    public class Class_7_2_Static :MonoBehaviour
    {
        //�D�R�A�ܼ�
        public int inventoryWater = 10;
        // �R�A�ܼ�: �׹����᭱�K�[����r static
        // �R�A�ܼƤ���ܦb�ݩʭ��O�W;
        public static int inventoryProp = 20;

        private void Awake()
        {
            inventoryWater = 6;
            inventoryProp = 30;
            Debug.Log($"<color=green>�Ĥ�: {inventoryWater} </color>");
            Debug.Log($"<color=aqua>�Ĥ�: {inventoryProp} </color>");

        }
    }
}
