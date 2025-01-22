using UnityEngine;

public class 課程_5_判斷式與列舉: MonoBehaviour
{
    [SerializeField, Header("血量"), Range(0, 100)]
    public int hp = 100;
    private void Update()
    {
        switch (hp)
        {
            case >= 80:
               Debug.Log("血量安全");
                break;
            case >= 60:
                Debug.Log("健康狀態有狀況");
                break;
            case  >= 40:
                Debug.Log("警告，快喝補的");
                break;
            case  >= 10:
                Debug.Log("快死掉了");
                break;
            case  0:
                Debug.Log("你眼前一黑，死掉了");
                break;
            default:
                break;
        }
    }
}
