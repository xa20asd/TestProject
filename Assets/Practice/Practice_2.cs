using UnityEngine;

public class Practice_2 :MonoBehaviour
{
    public float height;
    public float weight;

    private void Awake()
    {
        Debug.Log($"BMI¬°{BMI(height, weight)}");
    }
    

    private float BMI(float h, float w)
    {
        float hh = h / 100;
        float bmi = w / (hh * hh);
        return bmi;
        
    }
}
