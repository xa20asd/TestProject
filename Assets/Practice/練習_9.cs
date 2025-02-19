using UnityEngine;

public class 練習_9: MonoBehaviour
{
    float value = -999.321f;
    sbyte equalvalue = 0;

    private void Start()
    {
        equalvalue = (sbyte)value;

        Debug.Log(equalvalue);
        Debug.Log(equalvalue.GetType());

    }
}
