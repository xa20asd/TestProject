using UnityEngine;

public class Practice_3 : MonoBehaviour
{
    [SerializeField, Header("��q"), Range(0, 100)]
    public int hp = 100;
    private void Update()
    {
        if (hp >= 80)
        {
            Debug.Log("��q�w��");
        }
        else if (hp >= 60)
        {
            Debug.Log("���d���A�����p");
        }
        else if (hp >= 40)
        {
            Debug.Log("ĵ�i�A�ֳܸɪ�");
        }
        else if (hp >= 10)
        {
            Debug.Log("�֦����F");
        }
        else if (hp == 0)
        {
            Debug.Log("�A���e�@�¡A�����F");

        }
    }
}
