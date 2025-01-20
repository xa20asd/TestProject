using UnityEngine;

public class Practice_3 : MonoBehaviour
{
    [SerializeField, Header("血量"), Range(0, 100)]
    public int hp = 100;
    private void Update()
    {
        if (hp >= 80)
        {
            Debug.Log("血量安全");
        }
        else if (hp >= 60)
        {
            Debug.Log("健康狀態有狀況");
        }
        else if (hp >= 40)
        {
            Debug.Log("警告，快喝補的");
        }
        else if (hp >= 10)
        {
            Debug.Log("快死掉了");
        }
        else if (hp == 0)
        {
            Debug.Log("你眼前一黑，死掉了");

        }
    }
}
