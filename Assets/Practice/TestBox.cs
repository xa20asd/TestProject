using UnityEngine;
using UnityEngine.UI;

public class TestBox : MonoBehaviour
{
    public GameObject textObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void createText(string text) 
    {
        GameObject t = Instantiate(textObj, transform);
        t.GetComponent<Text>().text = text;
        checkText();
    }
    void checkText()
    {

        Debug.Log(transform.childCount);

        if (transform.childCount > 5) 
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }
}
