using UnityEngine;

namespace honordes
{
    /// <summary>
    /// �m�ߦs����ƥ�
    /// </summary>
    public class Class_7_1_GetData : MonoBehaviour
    {
        public Class_7_1_Property property;

        private void Awake()
        {
            //���o�t�@�����O�����
            Debug.Log(property.moveSpeed);   //�i�H���o���}�ܼ�
            //Debug.Log(property.turnSpeed); //���i�H���o�p�H�ܼ�

            //�]�w�t�@�����O���
            property.moveSpeed = 7.3f; //�i�H���o���}�ܼ�
            //property.turnSpeed = 5.4f; //���i�H���o�p�H�ܼ�

            Debug.Log(property.runSpeed); //�i�H���o���}�ܼ�
            //Debug.Log(property.sprintSpeed); //���i�H���o�p�H�ܼ�

            property.runSpeed = 66.6f;     //�i�H�]�w�� get ���ݩ�
            //property.jumpSpeed = 55.2f;  //���i�]�w�S�� set ���ݩ�(��Ū)

          

        }
    }
}
