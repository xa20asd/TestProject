using UnityEngine;

public class 課程_4_方法 : MonoBehaviour
{
    private bool t1 = true;
    private bool f1 = false;

    private void Boolean1()
    {
        Debug.Log(t1);
    }

    private bool Boolean2(bool f)
    {
        return f;
    }

    private void Awake()
    {
        Boolean1();                 //傳回true
        Debug.Log(Boolean2(f1));    //傳回false
    }
}
