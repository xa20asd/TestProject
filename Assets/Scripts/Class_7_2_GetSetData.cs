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

        public Class_7_2_Slime slimeGreen, slimeRed;
        
        private void Start()
        {
            //�D�R�A����
            slimeGreen.hp -= 10;
            Debug.Log($"�v�ܩi��HP: {slimeGreen.hp}");
            slimeRed.hp -= 30;
            Debug.Log($"�v�ܩi��HP: {slimeRed.hp}");

            //�R�A����
            //�R�A�����S��k�z�L����s��
            //slimeGreen.moveSpeed = 2.0f;
            Class_7_2_Slime.moveSpeed = 3.5f;
            Debug.Log($"�v�ܩi���ʳt��: {Class_7_2_Slime.moveSpeed}");
        }
    }

}