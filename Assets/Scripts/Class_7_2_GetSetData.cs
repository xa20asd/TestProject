using UnityEngine;

namespace honordes
{
    /// <summary>
    /// �m�ߨ��o�P�]�w�R�A���
    /// </summary>
    public class Class_7_2_GetSetData : MonoBehaviour
    {
        // ���o�D�R�A���
        //1. ���w�q�n��o������O���ܼ�
        //2. �z�L�ܼƨ��o�D�R�A���(����)

        public Class_7_2_Static class_7_2;

        private void Awake()
        {
            //�ܼƦW��.�D�R�A����
            //���o�D�R�A�ܼ�
            Debug.Log($"<color=red>�D�R�A����: {class_7_2.inventoryWater}</color>");
            //���o�D�R�A�ݩ�
            Debug.Log($"<color=red>�D�R�A����: {class_7_2.skillMain}</color>");
            //�I�s�D�R�A��k
            class_7_2.Punch();


            //���o�R�A���(����)
            //���O�W��.�R�A����
            Debug.Log($"<color=green>�R�A����: {Class_7_2_Static.inventoryProp}</color>");
            //���o�R�A�ݩ�
            Debug.Log($"<color=red>�D�R�A����: {Class_7_2_Static.skillSec}</color>");
            //�I�s�R�A��k
            Class_7_2_Static.Kick();
        }
    }

}